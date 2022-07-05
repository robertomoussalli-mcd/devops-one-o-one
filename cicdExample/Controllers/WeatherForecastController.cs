using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cicdExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            for (int i = 0; i < 10; i++)
            {
                var temp = rng.Next(-20, 40);
                yield return new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(i),
                    TemperatureC = temp,
                    Summary = Helper.GetDescriptionToLower(temp)
                };
            }
        }
    }
}
