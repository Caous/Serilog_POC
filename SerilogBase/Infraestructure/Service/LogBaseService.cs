
using Microsoft.Extensions.Logging;
using Serilog;
using SerilogBase.Infraestructure.Interface;
using SerilogBase.Model;

namespace SerilogBase.Infraestructure.Service
{
    public class LogBaseService : ILogBase
    {
        private Serilog.ILogger _logger;

        public LogBaseService()
        {
            _logger = new LoggerConfiguration()
            .CreateLogger();
        }

        public LogBase CreateModel(string nameSystem, LogLevel levelLog, string errorMensagem)
        {
            return new LogBase() { NameSystem = nameSystem, LevelInformation = levelLog, ErrorMensagem = errorMensagem };
        }

        public void WriteLog(LogBase log)
        {
            
            switch (log.LevelInformation)
            {
                case LogLevel.Information:
                    _logger.Information(log.ErrorMensagem);
                    break;
                case LogLevel.Warning:
                    _logger.Warning(log.ErrorMensagem);
                    break;
            }            

        }
    }
}
