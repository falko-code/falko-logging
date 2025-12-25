using Falko.Logging.Factories;
using Falko.Logging.Logs;
using Falko.Logging.Renderers;
using Falko.Logging.Runtimes;
using Falko.Logging.Targets;

using var loggerRuntime = new LoggerRuntime().Initialize(builder => builder
    .SetLevel(LogLevels.InfoAndAbove)
    .AddTarget(SimpleLogContextRenderer.Instance,
        LoggerConsoleTarget.Instance
            .AsConcurrent())
    .AddTarget(SimpleLogContextRenderer.Instance,
        new LoggerFileTarget("app_name", "./Logs")
            .AsConcurrent()));

var logger = typeof(Program).CreateLogger(loggerRuntime);

logger.Info("PI is {PI}", Math.PI);
