using Microsoft.Extensions.Logging;

namespace SerilogBase.Model
{
    public class LogBase
    {
        public string NameSystem { get; set; }
        public LogLevel LevelInformation { get; set; }
        public string ErrorMensagem { get; set; }
    }
}
