# SpriteSync

A modern digital asset marketplace tailored for indie game developers to discover, preview, and license 2D spritesheets, tilesets, UI packs, and audio assets. Built with **C# Blazor** and **Tailwind CSS**, combining stateful client-side logic with a sleek dark-mode aesthetic.

---

## Tech Stack

- **Framework:** .NET 8 / Blazor (C#)
- **Styling:** Tailwind CSS (JIT, Dark Mode, Inter & JetBrains Mono typography)
- **State Management:** Injected Scoped `CartStateService`

---

## 3-Page Architecture

### 1. Marketplace & Discovery Hub (`/`)
* **Live Search & Filtering:** Dynamic, zero-reload filtering across categories (Sprites, Tilesets, UI, Audio), resolutions (16x16, 32x32), and art styles powered by in-memory LINQ queries.
* **Component-Driven Grid:** Modular `<AssetCard />` items featuring crisp `pixelated` rendering, creator badges, format tags (`.png`, `.aseprite`), and hover-reveal cart actions.

### 2. Interactive Asset Inspector (`/asset/{Id:int}`)
* **Live Animation Tester:** An interactive preview canvas with a playback engine—toggle animation states (*Idle*, *Run*, *Attack*), adjust FPS, and switch canvas backgrounds.
* **Dynamic License Switcher:** Real-time price recalculation between Personal and Commercial licenses with dynamic C# SKU packaging and sticky purchase controls.

### 3. Checkout & Creator Vault (`/vault`)
* **Seamless Checkout:** Validated `<EditForm>` checkout flow with promo code support and real-time cart breakdowns.
* **Asset Library ("My Vault"):** Post-purchase dashboard with `.zip` download streaming, version tracking (`v1.2`), and license key generation.

---

## Getting Started

### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
- [Node.js & npm](https://nodejs.org/) (for Tailwind CLI)

### Installation & Run

1. **Clone the repository:**
   ```bash
   git clone [https://github.com/colynpacaldo/SpriteSync.git](https://github.com/colynpacaldo/SpriteSync.git)
   cd SpriteSync
