using _5_paskaita_web_API.Responses;

namespace _5_paskaita_web_API.Services.Interfaces
{
    public interface IWeatherService
    {
        Task<WeatherApiResponse> GetWeahterApiResponse(string city);
    }
}
