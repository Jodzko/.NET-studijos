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
        public WeatherService(IOptions<WeatherSettings> weatherSettings)
        {
            _weatherSettings = weatherSettings.Value;
        }
        public async Task<WeatherApiResponse> GetWeahterApiResponse(string city)
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
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            return JsonSerializer.Deserialize<WeatherApiResponse>(body, options);
        }
    }
    }

