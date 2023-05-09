using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherMicroservice.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{temperature}")]
        public ActionResult<string> GetTemperature(int temperature, [FromQuery] bool israining = false)
        {
            string message = "";

            if (temperature >= 0 && temperature <= 10)
            {
                message = "Wear as many clothes as possible";
            }
            else if (temperature > 10 && temperature <= 20)
            {
                message = "Wear at least 4 layers with gloves and a hat";
            }
            else if (temperature > 20 && temperature <= 40)
            {
                message = "Wear a winter coat at minimum";
            }
            else if (temperature > 40 && temperature <= 60)
            {
                message = "Wear a hoodie or light jacket";
            }
            else if (temperature > 60)
            {
                message = "No jacket necessary";
            }
            else
            {
                // Handle invalid temperature values
                return BadRequest("Invalid temperature value.");
            }

            if (israining)
            {
                message += ". Bring an umbrella.";
            }

            return message;
        }
    }
}
