namespace Falko.Logging.Renderers;

internal abstract class PersistentLogMessageRenderer : ILogMessageRenderer
{
    private string? _message;

    public string Render()
    {
        var currentMessage = _message;
        if (currentMessage is not null) return currentMessage;

        var newMessage = RenderCore();
        _message = newMessage;
        return newMessage;
    }

    protected abstract string RenderCore();
}
