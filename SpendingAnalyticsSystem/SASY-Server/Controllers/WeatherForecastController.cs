using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SpendingAnalyticsSystem.API.DIConfiguration;

namespace SpendingAnalyticsSystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private  IOptions<PositionOptions> _options;
        private IOptions<DbOptions> _dbOptions;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IConfiguration configuration, IOptions<PositionOptions> options, IOptions<DbOptions> dbOptions)
        {
            _logger = logger;
            _options = options;
            _dbOptions = dbOptions;

            var test = configuration.GetSection("Position").GetRequiredSection("Title");

        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}