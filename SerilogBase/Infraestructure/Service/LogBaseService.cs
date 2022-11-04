
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using SerilogBase.Infraestructure.Configuration;
using SerilogBase.Infraestructure.Interface;
using SerilogBase.Model;

namespace SerilogBase.Infraestructure.Service
{
    public class LogBaseService : ILogBase
    {
        private Serilog.ILogger _logger;

        public LogBaseService(LogBaseModel config)
        {
            _logger = LogBaseConfig.ConfigurationLogBase(config);
            
        }

        //public LogBaseService(IConfiguration configuration)
        //{
        //    _logger = LogBaseConfig.ConfigurationLogBaseJson(configuration);
        //}

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
