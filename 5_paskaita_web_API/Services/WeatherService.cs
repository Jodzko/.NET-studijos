using _5_paskaita_web_API.Models;
using _5_paskaita_web_API.Persistence;
using _5_paskaita_web_API.Responses;
using _5_paskaita_web_API.Services.Interfaces;
using _5_paskaita_web_API.Settings;
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace _5_paskaita_web_API.Services
{

    public class WeatherService : IWeatherService
    {
        private readonly WeatherSettings _weatherSettings;
        private readonly WeatherDbContext _context;

        public WeatherService(IOptions<WeatherSettings> weatherSettings, WeatherDbContext context)
        {
            _context = context;
            _weatherSettings = weatherSettings.Value;
        }
        public async Task<string> GetWeahterApiResponse(string city)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{_weatherSettings.Url}current?access_key={_weatherSettings.AccessKey}&query={city}")
            };
            using var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();            
            return body;
        }
        public void AddWeather(WeatherData weather)
        {
            _context.Add(weather);
            _context.SaveChanges();
        }

        public IEnumerable<WeatherData> GetWeathers()
        {
            return _context.Weathers;
        }
        public async void UpdateWeather(WeatherData weather)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{_weatherSettings.Url}current?access_key={_weatherSettings.AccessKey}&query={weather.City}")
            };
            using var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            weather.AllData = body;
            weather.AddedTime = DateTime.Now;
            _context.Weathers.Update(weather);
            _context.SaveChanges();
        }
    }
    }

