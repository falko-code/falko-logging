using Falko.Logging.Logs;
using Falko.Logging.Renderers;

namespace Falko.Logging.Contexts;

[method: MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
public readonly struct LogContext(string source, LogLevel level, DateTime time, ILogMessageRenderer message)
{
    public readonly string Source = source;

    public readonly LogLevel Level = level;

    public readonly DateTime Time = time;

    public readonly ILogMessageRenderer Message = message;

    public Exception? Exception { get; init; }
}
