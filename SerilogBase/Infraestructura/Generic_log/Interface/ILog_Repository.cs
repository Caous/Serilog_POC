using Microsoft.Extensions.Logging;
using Serilog;

namespace Serilog_Poc.Infraestructura.Generic_log.Interface
{
    public interface ILog_Repository: Serilog.ILogger
    {
        void CreateLog(string message, LogLevel logLevel);

    }
}
