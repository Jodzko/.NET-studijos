using _5_paskaita_web_API.Models;
using _5_paskaita_web_API.Persistence;
using _5_paskaita_web_API.Responses;
using _5_paskaita_web_API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace _5_paskaita_web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyWeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;
        //private readonly IWeatherDatabase _weatherDb;
        private readonly ILogger<MyWeatherController> _logger;
        public MyWeatherController(IWeatherService weatherService, ILogger<MyWeatherController> logger)
        {
            _weatherService = weatherService;
            _logger = logger;
            //_weatherDb = weatherDb;
        }
        [HttpGet]
        public async Task<ActionResult<WeatherApiResponse>> Get(string city)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var weathersInDb =_weatherService.GetWeathers();
            var existing = weathersInDb.FirstOrDefault(x => x.City == city);
            if (existing != null)
                {
                if((DateTime.Now - existing.AddedTime).TotalMinutes > 30)
                {
                    Update(city);
                    return Ok(existing.AllData);
                    
                }
                else
                {
                    var newData = JsonSerializer.Deserialize<WeatherApiResponse>(existing.AllData, options);
                    return Ok(newData);
                }
            }
            else
            {
                var result = await _weatherService.GetWeahterApiResponse(city);
                if (result == null)
                {
                    return NotFound();
                }
                var newAddition = new WeatherData(city, result);
                _weatherService.AddWeather(newAddition);
                return Ok(JsonSerializer.Deserialize<WeatherApiResponse>(result, options));
            }
        }

        [HttpPut]
        public async Task<ActionResult<WeatherApiResponse>> Update(string city)
        {
            var dbInfo = _weatherService.GetWeathers();
            var existingData = dbInfo.FirstOrDefault(x => x.City == city);
            if (existingData != null)
            {
                var result = await _weatherService.GetWeahterApiResponse(city);
                _weatherService.UpdateWeather(existingData);
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                return Ok(result);
            }
            else
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
}
