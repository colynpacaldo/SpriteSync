namespace SpriteSync.Models;

public class Asset
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Category { get; set; } = ""; 
    public decimal BasePrice { get; set; }
    public string ImageUrl { get; set; } = "";
    public string[] Formats { get; set; } = Array.Empty<string>();
}