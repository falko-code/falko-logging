using System.Diagnostics;

namespace Falko.Logging.Debugs;

public static class DebugEventLogger
{
    private static event DebugLogEventHandler? Handlers;

    [Conditional("DEBUG")]
    public static void AddHandler(DebugLogEventHandler handler)
    {
        Handlers += handler;
    }

    [Conditional("DEBUG")]
    public static void RemoveHandler(DebugLogEventHandler handler)
    {
        Handlers -= handler;
    }

    [Conditional("DEBUG")]
    public static void Handle(string? message, Exception? exception = null)
    {
        try
        {
            Handlers?.Invoke(message, exception);
        }
        catch
        {
            // Nothing to do
        }
    }
}
