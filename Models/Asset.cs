namespace SpriteSync.Models;

public class Asset
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Category { get; set; } = ""; // Spritesheet, Tileset, UI Pack, SFX
    public string ArtStyle { get; set; } = "Pixel Art"; // Pixel Art, Vector, Hand-drawn
    public string Creator { get; set; } = "@PixelForge";
    public string CreatorAvatar { get; set; } = "🧙‍♂️";
    public decimal BasePrice { get; set; }
    public double Rating { get; set; } = 4.9;
    public int ReviewCount { get; set; } = 42;
    public int Downloads { get; set; } = 1240;
    public bool IsStaffPick { get; set; }
    public string ImageUrl { get; set; } = "";
    public string[] Formats { get; set; } = Array.Empty<string>();
    public string Dimensions { get; set; } = "32x32px";
    public int FrameCount { get; set; } = 24;
    public string Version { get; set; } = "v1.2";
    public string VersionNotes { get; set; } = "Added jump & attack frames";
    public string[] CompatibleEngines { get; set; } = new[] { "Godot", "Unity" };
}
