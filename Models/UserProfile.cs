namespace SpriteSync.Models;

public class UserProfile
{
    public string Username { get; set; } = "Alex Vance";
    public string Handle { get; set; } = "@alex_gamedev";
    public string Role { get; set; } = "Solo Indie Developer";
    public string Bio { get; set; } = "Crafting a sci-fi metroidvania in Godot 4.3. Passionate about 16-bit pixel art, CRT shaders, and responsive combat.";
    public string Avatar { get; set; } = "👾";
    public string PreferredEngine { get; set; } = "Godot 4.3";
    public string TargetPlatform { get; set; } = "Steam / PC";
    public int AssetsOwned { get; set; } = 14;
    public int ReviewsWritten { get; set; } = 6;
    public decimal TotalSpent { get; set; } = 184.50m;
}
