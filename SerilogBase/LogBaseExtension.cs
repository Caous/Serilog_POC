using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SerilogBase.Infraestructure.Interface;
using SerilogBase.Infraestructure.Service;

namespace SerilogBase
{
    public static class LogBaseExtension
    {
        public static void AddBMGLogger(this IServiceCollection services) {
            
            
            services.AddScoped<ILogBase, LogBaseService>();
        }
    }
}
