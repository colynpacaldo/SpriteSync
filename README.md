# SpriteSync

SpriteSync is an interactive storefront prototype for indie game developers. Browse sample 2D assets, inspect sprite animations, compare license tiers, and exercise a simulated cart, checkout, and creator vault.

> **Prototype notice:** Listings and account history are sample data held in memory. Checkout does not process payments, downloads do not deliver files, and uploads are not stored. Do not enter real personal or payment information.

## App structure

- `Pages/`: marketplace, asset detail, and vault/checkout routes.
- `Components/`: reusable asset cards, sprite animator, and toast UI.
- `Services/`: in-memory catalog, cart and license rules, formatting, and notifications.
- `Models/`: catalog, cart, vault, review, and profile data.

## Routes

- `/`: searchable, filterable, sortable sample catalog.
- `/asset/{Id:int}`: asset detail, sprite animation preview, and license selection.
- `/vault`: simulated checkout, sample vault, and profile settings.

## Requirements

- [.NET 8 SDK](https://dotnet.microsoft.com/download)

## Build, test, and run

Run these commands from the repository root:

```powershell
dotnet restore SpriteSync.sln
dotnet build SpriteSync.sln --no-restore
dotnet test SpriteSync.sln --no-restore
dotnet run --project SpriteSync.csproj
```

The app uses the Tailwind CDN for prototype styling; use a local CSS build pipeline before production deployment.
