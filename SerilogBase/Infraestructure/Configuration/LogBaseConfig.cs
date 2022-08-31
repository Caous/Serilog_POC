using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Events;
using Serilog.Filters;

namespace SerilogBase.Infraestructure.Configuration
{
    public static class LogBaseConfig
    {       

        public static ILogger ConfigurationLogBase()
        {
            return Log.Logger = new LoggerConfiguration()
           .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Information)
           .Enrich.FromLogContext()
           .Enrich.WithProperty("ApplicationName", $"API Serilog")
           .Filter.ByExcluding(Matching.FromSource("Microsoft.AspNetCore.StaticFiles"))
           .Filter.ByExcluding(z => z.MessageTemplate.Text.Contains("Business error"))
           .WriteTo.Async(wt => wt.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj} {Properties:j}{NewLine}{Exception}"))
           .CreateLogger();
            //.ReadFrom.Configuration(configuration)
            //.CreateLogger();

        }
    }
}
