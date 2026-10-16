namespace SpriteSync.Models;

public class Asset
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Category { get; set; } = ""; 
    public string ArtStyle { get; set; } = "Pixel Art"; 
    public string Creator { get; set; } = "@PixelForge";
    public decimal BasePrice { get; set; }
    public double Rating { get; set; } = 4.9;
    public int ReviewCount { get; set; } = 32;
    public string ImageUrl { get; set; } = "";
    public string[] Formats { get; set; } = Array.Empty<string>();
    public string Dimensions { get; set; } = "32x32px";
    public int FrameCount { get; set; } = 24;
    public string Version { get; set; } = "v1.2";
    public string VersionNotes { get; set; } = "Added jump & attack frames";
}
