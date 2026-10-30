using SpriteSync.Models;

namespace SpriteSync.Services;

public class AssetService
{
    private readonly List<Asset> _assets = new()
    {
        new Asset
        {
            Id = 1, Name = "Cyberpunk Hero Animator", Category = "Spritesheet", ArtStyle = "Pixel Art", Resolution = "64x64", Dimensions = "64x64px",
            Creator = "@PixelForge", CreatorAvatar = "🧙‍♂️", BasePrice = 15.00m, Rating = 4.9, ReviewCount = 42, Downloads = 1420, FrameCount = 14,
            Formats = new[] { ".png", ".aseprite" }, IsStaffPick = true, Version = "v1.2", VersionNotes = "Added jump & attack frames",
            ImageUrl = "/images/previews/cyberpunk-hero.svg",
            Tags = new[] { "cyberpunk", "hero", "metroidvania", "godot-ready" },
            Description = "A fully animated cyberpunk hero with Idle, Run and Attack cycles. Strict palette, clean outlines, engine-ready sheet layout.",
            SpriteSheet = new SpriteSheetConfig
            {
                SheetUrl = "/images/sprites/cyberpunk-sheet.svg", FrameWidth = 64, FrameHeight = 64,
                Animations = new()
                {
                    new SpriteAnimation { Name = "Idle", Row = 0, FrameCount = 4 },
                    new SpriteAnimation { Name = "Run", Row = 1, FrameCount = 6 },
                    new SpriteAnimation { Name = "Attack", Row = 2, FrameCount = 4 }
                }
            },
            Reviews = new()
            {
                new Review { Author = "@tilemancer", Rating = 5, Date = "2 weeks ago", Comment = "Dropped straight into Godot. The run cycle is superb." },
                new Review { Author = "@jamgoblin", Rating = 5, Date = "1 month ago", Comment = "Saved my jam entry. Great palette." }
            }
        },
        new Asset
        {
            Id = 2, Name = "Dark Fantasy Biome 16x16", Category = "Tileset", ArtStyle = "Pixel Art", Resolution = "16x16", Dimensions = "16x16px",
            Creator = "@ForestNomad", CreatorAvatar = "🌲", BasePrice = 12.50m, Rating = 4.8, ReviewCount = 19, Downloads = 890, FrameCount = 256, Version = "v2.1", VersionNotes = "Added cavern autotile set",
            Formats = new[] { ".png", ".tsx" },
            ImageUrl = "/images/previews/dark-fantasy-tileset.svg",
            Tags = new[] { "tileset", "dark-fantasy", "forest", "autotile" },
            Description = "Autotile-ready dark fantasy biome with forest, ruins and cavern sets.",
            Reviews = new() { new Review { Author = "@mapmaker", Rating = 5, Date = "3 weeks ago", Comment = "Autotiles just work." } }
        },
        new Asset
        {
            Id = 3, Name = "Sci-Fi HUD & Modular UI", Category = "UI Pack", ArtStyle = "Vector", Resolution = "Any", Dimensions = "Scalable",
            Creator = "@InterfaceLab", CreatorAvatar = "⚡", BasePrice = 24.00m, Rating = 5.0, ReviewCount = 31, Downloads = 2100, FrameCount = 120,
            Formats = new[] { ".svg", ".png" }, IsStaffPick = true, CompatibleEngines = new[] { "Godot", "Unity", "GameMaker" },
            ImageUrl = "/images/previews/scifi-hud.svg",
            Tags = new[] { "ui", "hud", "sci-fi", "vector" },
            Description = "Modular HUD kit with health bars, inventory panels, dialogs and icon sets in resolution-independent vectors.",
            Reviews = new() { new Review { Author = "@hudhero", Rating = 5, Date = "1 week ago", Comment = "Best HUD kit I have bought." } }
        },
        new Asset
        {
            Id = 4, Name = "Retro 8-Bit Dungeon Audio", Category = "SFX", ArtStyle = "Chiptune / Synth", Resolution = "Any", Dimensions = "44.1kHz",
            Creator = "@ChiptuneWiz", CreatorAvatar = "🎹", BasePrice = 9.00m, Rating = 4.7, ReviewCount = 58, Downloads = 640, FrameCount = 64, Version = "v1.0", VersionNotes = "Initial release",
            Formats = new[] { ".wav", ".ogg" },
            ImageUrl = "/images/previews/dungeon-audio.svg",
            Tags = new[] { "sfx", "chiptune", "dungeon", "8-bit" },
            Description = "64 chiptune sound effects for dungeon crawlers: pickups, hits, doors, spells and UI blips.",
            Reviews = new() { new Review { Author = "@bitcrusher", Rating = 4, Date = "2 months ago", Comment = "Crunchy and fun." } }
        },
        new Asset
        {
            Id = 5, Name = "Neon Alley Tileset 32x32", Category = "Tileset", ArtStyle = "Pixel Art", Resolution = "32x32", Dimensions = "32x32px",
            Creator = "@PixelForge", CreatorAvatar = "🧙‍♂️", BasePrice = 18.00m, Rating = 4.8, ReviewCount = 12, Downloads = 410, FrameCount = 192,
            Formats = new[] { ".png", ".tsx", ".aseprite" },
            ImageUrl = "/images/previews/neon-alley-tileset.svg",
            Tags = new[] { "cyberpunk", "tileset", "city", "neon" },
            Description = "Rain-soaked neon alley tiles that pair with the Cyberpunk Hero Animator.",
            Reviews = new() { new Review { Author = "@rainyday", Rating = 5, Date = "5 days ago", Comment = "Gorgeous lighting tiles." } }
        }
    };

    public IReadOnlyList<Asset> GetAll() => _assets;
    public Asset? GetById(int id) => _assets.FirstOrDefault(a => a.Id == id);
    public IEnumerable<Asset> GetByCreator(string creator, int excludeId) =>
        _assets.Where(a => a.Creator == creator && a.Id != excludeId);
}
