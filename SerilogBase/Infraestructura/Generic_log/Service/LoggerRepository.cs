using Microsoft.Extensions.Logging;
using Serilog.Events;
using Serilog_Poc.Infraestructura.Generic_log.Interface;

namespace Serilog_Poc.Infraestructura.Generic_log.Service
{
    public class LoggerRepository : ILog_Repository
    {
        private readonly ILogger logger;
        public LoggerRepository()
        {
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            IDisposable scope = null;
            return scope;
        }


        public void CreateLog(string message, LogLevel logLevel)
        {
            throw new NotImplementedException();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {

        }

        public void Write(LogEvent logEvent)
        {
            throw new NotImplementedException();
        }
    }
}
