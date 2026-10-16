namespace SpriteSync.Models;

public class VaultItem
{
    public int Id { get; set; }
    public string AssetName { get; set; } = "";
    public string Category { get; set; } = "";
    public string LicenseTier { get; set; } = "Personal";
    public string LicenseKey { get; set; } = "";
    public string Version { get; set; } = "v1.0";
    public string VersionNotes { get; set; } = "";
    public DateTime PurchaseDate { get; set; } = DateTime.Now;
    public bool IsDownloading { get; set; }
    public int DownloadProgress { get; set; }
    public bool IsDownloaded { get; set; }
}
