namespace SpriteSync.Services;
using SpriteSync.Models;

public class CartStateService
{
    public List<CartItem> CartItems { get; private set; } = new();
    public List<VaultItem> VaultItems { get; private set; } = new();
    public bool IsDrawerOpen { get; private set; } = false;
    public string AppliedDiscountCode { get; private set; } = "";
    public decimal DiscountPercent { get; private set; } = 0m;

    public event Action? OnChange;

    public CartStateService()
    {
        VaultItems.Add(new VaultItem
        {
            Id = 99,
            AssetName = "Fantasy Forest Tileset",
            Category = "Tileset",
            LicenseTier = "Commercial",
            LicenseKey = "SPR-COMM-8921-FNT",
            Version = "v1.2",
            VersionNotes = "Added jump frames & water autotiles",
            PurchaseDate = DateTime.Now.AddDays(-2)
        });
    }

    public bool IsInCart(int assetId) => CartItems.Any(ci => ci.Asset.Id == assetId);

    public void AddToCart(Asset asset, string licenseTier = "Personal", decimal price = 0)
    {
        if (price <= 0)
        {
            price = licenseTier == "Commercial" ? asset.BasePrice * 3 : asset.BasePrice;
        }

        var existing = CartItems.FirstOrDefault(ci => ci.Asset.Id == asset.Id);
        if (existing != null)
        {
            existing.LicenseTier = licenseTier;
            existing.Price = price;
        }
        else
        {
            CartItems.Add(new CartItem
            {
                Asset = asset,
                LicenseTier = licenseTier,
                Price = price
            });
        }
        
        IsDrawerOpen = true; 
        NotifyStateChanged();
    }

    public void RemoveFromCart(int assetId)
    {
        CartItems.RemoveAll(ci => ci.Asset.Id == assetId);
        NotifyStateChanged();
    }

    public void ClearCart()
    {
        CartItems.Clear();
        AppliedDiscountCode = "";
        DiscountPercent = 0m;
        NotifyStateChanged();
    }

    public void ToggleDrawer()
    {
        IsDrawerOpen = !IsDrawerOpen;
        NotifyStateChanged();
    }

    public void CloseDrawer()
    {
        IsDrawerOpen = false;
        NotifyStateChanged();
    }

    public bool ApplyDiscount(string code)
    {
        var clean = code.Trim().ToUpperInvariant();
        if (clean == "INDIE20" || clean == "INDIE15")
        {
            AppliedDiscountCode = clean;
            DiscountPercent = clean == "INDIE20" ? 0.20m : 0.15m;
            NotifyStateChanged();
            return true;
        }
        else if (clean == "STUDENT" || clean == "STUDENT25")
        {
            AppliedDiscountCode = clean;
            DiscountPercent = 0.25m;
            NotifyStateChanged();
            return true;
        }
        return false;
    }

    public decimal Subtotal => CartItems.Sum(ci => ci.Price);
    public decimal DiscountAmount => Subtotal * DiscountPercent;
    public decimal Total => Math.Max(0, Subtotal - DiscountAmount);

    public void Checkout()
    {
        foreach (var item in CartItems)
        {
            VaultItems.Insert(0, new VaultItem
            {
                Id = item.Asset.Id,
                AssetName = item.Asset.Name,
                Category = item.Asset.Category,
                LicenseTier = item.LicenseTier,
                LicenseKey = $"SPR-{item.LicenseTier.Substring(0, 4).ToUpper()}-{Random.Shared.Next(1000, 9999)}-{item.Asset.Id}",
                Version = item.Asset.Version,
                VersionNotes = item.Asset.VersionNotes,
                PurchaseDate = DateTime.Now
            });
        }
        ClearCart();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}
