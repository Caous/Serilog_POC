using Microsoft.AspNetCore.Mvc;
using SerilogBase.Infraestructure.Interface;

namespace Serilog_Poc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogBase _logBase;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ILogBase logBase)
        {
            _logBase = logBase;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            var log = _logBase.CreateModel("Teste", LogLevel.Information, "Sem erro");
            _logBase.WriteLog(log);
            try
            {
                return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                })
                .ToArray();
            }
            catch (Exception ex)
            {
                log = _logBase.CreateModel("Error Method WeatherForecast.Get() with Error", LogLevel.Information, ex.ToString());
                _logBase.WriteLog(log);
                throw;
            }
        }
    }
}