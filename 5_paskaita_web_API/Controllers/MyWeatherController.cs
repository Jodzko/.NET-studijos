using _5_paskaita_web_API.Responses;
using _5_paskaita_web_API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace _5_paskaita_web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyWeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;
        private readonly ILogger<MyWeatherController> _logger;
        public MyWeatherController(IWeatherService weatherService, ILogger<MyWeatherController> logger)
        {
            _weatherService = weatherService;
            _logger = logger;
        }

        [HttpGet("ByCity")]
        public async Task<ActionResult<WeatherApiResponse>> Get(string city)
        {
            var result = await _weatherService.GetWeahterApiResponse(city);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
