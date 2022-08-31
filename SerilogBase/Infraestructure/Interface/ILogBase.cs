using Microsoft.Extensions.Logging;
using SerilogBase.Model;

namespace SerilogBase.Infraestructure.Interface
{
    public interface ILogBase 
    {
        LogBase CreateModel(string nameSystem, LogLevel levelLog, string errorMensagem);

        void WriteLog(LogBase log);
    }
}
