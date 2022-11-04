using Microsoft.Extensions.DependencyInjection;
using SerilogBase.Infraestructure.Interface;
using SerilogBase.Infraestructure.Service;
using SerilogBase.Model;

namespace SerilogBase
{
    public static class LogBaseExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="logModel"></param>
        public static void AddLogBaseLogger(this IServiceCollection services, LogBaseModel logModel)
        {
            services.AddSingleton(logModel);

            services.AddScoped<ILogBase, LogBaseService>();
        }
    }
}
