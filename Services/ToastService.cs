namespace SpriteSync.Services;

public record ToastMessage(Guid Id, string Text, string Kind);

public class ToastService
{
    public event Action? OnChange;
    private readonly List<ToastMessage> _messages = new();
    public IReadOnlyList<ToastMessage> Messages => _messages;

    public void Show(string text, string kind = "info")
    {
        var msg = new ToastMessage(Guid.NewGuid(), text, kind);
        _messages.Add(msg);
        OnChange?.Invoke();
        _ = Task.Delay(3500).ContinueWith(_ =>
        {
            _messages.Remove(msg);
            OnChange?.Invoke();
        });
    }
}
