using _5_paskaita_web_API.Models;
using _5_paskaita_web_API.Responses;

namespace _5_paskaita_web_API.Services.Interfaces
{
    public interface IWeatherService
    {
        Task<string> GetWeahterApiResponse(string city);
        void AddWeather(WeatherData weather);
        IEnumerable<WeatherData> GetWeathers();
        void UpdateWeather(WeatherData weather);
    }
}
