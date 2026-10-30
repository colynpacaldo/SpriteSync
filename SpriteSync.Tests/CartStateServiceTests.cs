using SpriteSync.Models;
using SpriteSync.Services;
using Xunit;

namespace SpriteSync.Tests;

public class CartStateServiceTests
{
    [Fact]
    public void CheckoutAddsDiscountedTotalToSpend()
    {
        var cart = new CartStateService();
        var asset = new Asset { Id = 3, Name = "Test asset", BasePrice = 10m };

        cart.AddToCart(asset);
        Assert.True(cart.ApplyDiscount("INDIE20"));
        cart.Checkout();

        Assert.Equal(8m, cart.User.TotalSpent - 42.50m);
        Assert.Equal(3, cart.User.AssetsOwned);
        Assert.Equal(3, cart.VaultItems.Count);
        Assert.Empty(cart.CartItems);
    }

    [Fact]
    public void CommercialUpgradeChargesOnlyDifferenceAndKeepsSingleVaultItem()
    {
        var cart = new CartStateService();
        var asset = new Asset { Id = 2, Name = "Dark Fantasy Biome", BasePrice = 12.50m };

        cart.AddToCart(asset, "Commercial");
        cart.Checkout();

        var owned = Assert.Single(cart.VaultItems, item => item.AssetId == asset.Id);
        Assert.Equal("Commercial", owned.LicenseTier);
        Assert.Equal(25m, cart.User.TotalSpent - 42.50m);
        Assert.Equal(2, cart.User.AssetsOwned);
    }

    [Fact]
    public void CannotAddAlreadyCommerciallyLicensedAsset()
    {
        var cart = new CartStateService();

        cart.AddToCart(new Asset { Id = 1, BasePrice = 15m }, "Commercial");

        Assert.Empty(cart.CartItems);
    }

    [Fact]
    public void RejectsUnknownLicenseTier()
    {
        var cart = new CartStateService();

        Assert.Throws<ArgumentOutOfRangeException>(() =>
            cart.AddToCart(new Asset { Id = 3, BasePrice = 10m }, "Enterprise"));
    }
}
