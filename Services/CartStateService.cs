namespace SpriteSync.Services;
using SpriteSync.Models;

public class CartStateService
{
    public List<Asset> CartItems { get; private set; } = new();
    public event Action? OnChange;

    public void AddToCart(Asset asset)
    {
        if (!CartItems.Any(a => a.Id == asset.Id))
        {
            CartItems.Add(asset);
            NotifyStateChanged();
        }
    }

    public void ClearCart()
    {
        CartItems.Clear();
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}