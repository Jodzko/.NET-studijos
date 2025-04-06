using _5_paskaita_web_API.Models;

namespace _5_paskaita_web_API.Persistence
{
    public interface IWeatherDatabase
    {
        void AddWeather(WeatherData weather);
        IEnumerable<WeatherData> GetWeathers();
        void UpdateWeather(WeatherData weather, string city);
    }
}
