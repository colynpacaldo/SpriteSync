using Microsoft.AspNetCore.Components;

namespace SpriteSync.Services;

/// <summary>Base class that re-renders whenever the cart / vault changes.</summary>
public abstract class CartAwareComponent : ComponentBase, IDisposable
{
    [Inject] protected CartStateService Cart { get; set; } = default!;

    protected override void OnInitialized() => Cart.OnChange += HandleCartChanged;

    private void HandleCartChanged() => _ = InvokeAsync(StateHasChanged);

    public virtual void Dispose()
    {
        Cart.OnChange -= HandleCartChanged;
        GC.SuppressFinalize(this);
    }
}
