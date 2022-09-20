using Microsoft.Extensions.Logging;
using SerilogBase.Infraestructure.Interface;

namespace Schedule_Poc
{
    public class TestedLog
    {
        private readonly ILogBase _logger;

        // Use constructor injection for the dependencies
        public TestedLog(ILogBase logger)
        {
            _logger = logger;
        }
        public void InicializeLog() {

            var log = _logger.CreateModel("Teste", LogLevel.Warning, "Teste Vinicius");
            _logger.WriteLog(log);

        }
    }
}
