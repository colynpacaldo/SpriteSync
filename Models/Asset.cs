namespace SpriteSync.Models;

public class Asset
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Category { get; set; } = ""; // Spritesheet, Tileset, UI Pack, SFX
    public string ArtStyle { get; set; } = "Pixel Art"; // Pixel Art, Vector, Chiptune / Synth
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
    public string Resolution { get; set; } = "32x32"; // 16x16, 32x32, 64x64, Any
    public int FrameCount { get; set; } = 24;
    public string Version { get; set; } = "v1.2";
    public string VersionNotes { get; set; } = "Added jump & attack frames";
    public string[] CompatibleEngines { get; set; } = new[] { "Godot", "Unity" };
    public string[] Tags { get; set; } = Array.Empty<string>();
    public string Description { get; set; } = "";
    public SpriteSheetConfig? SpriteSheet { get; set; }
    public List<Review> Reviews { get; set; } = new();
}

public class SpriteAnimation
{
    public string Name { get; set; } = "Idle";
    public int Row { get; set; } = 0;
    public int FrameCount { get; set; } = 4;
}

public class SpriteSheetConfig
{
    public string SheetUrl { get; set; } = "";
    public int FrameWidth { get; set; } = 64;
    public int FrameHeight { get; set; } = 64;
    public List<SpriteAnimation> Animations { get; set; } = new();
}

public class Review
{
    public string Author { get; set; } = "";
    public int Rating { get; set; } = 5;
    public string Date { get; set; } = "Recent";
    public string Comment { get; set; } = "";
}
