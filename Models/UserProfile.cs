namespace SpriteSync.Models;

public class UserProfile
{
    public string Username { get; set; } = "Indie Developer";
    public string Handle { get; set; } = "@indie_dev";
    public string Email { get; set; } = "developer@example.invalid";
    public string Role { get; set; } = "Solo Indie Developer";
    public string Bio { get; set; } = "Building a game and collecting useful assets for my next project.";
    public string Avatar { get; set; } = "👾";
    public string PreferredEngine { get; set; } = "Godot 4.3";
    public string TargetPlatform { get; set; } = "Steam / PC";
    public int AssetsOwned { get; set; } = 2;
    public int ReviewsWritten { get; set; } = 6;
    public decimal TotalSpent { get; set; } = 42.50m;
}
