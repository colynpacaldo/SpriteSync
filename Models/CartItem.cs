namespace SpriteSync.Models;

public class CartItem
{
    public Asset Asset { get; set; } = new();
    public string LicenseTier { get; set; } = "Personal";
    public decimal Price { get; set; }
}
