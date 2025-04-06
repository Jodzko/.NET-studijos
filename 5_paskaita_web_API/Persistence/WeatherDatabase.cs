using _5_paskaita_web_API.Models;

namespace _5_paskaita_web_API.Persistence
{
    public class WeatherDatabase : IWeatherDatabase
    {
        public readonly WeatherDbContext _context;

        public WeatherDatabase(WeatherDbContext context)
        {
            _context = context;
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
        public void UpdateWeather(WeatherData weather, string city)
        {
            var existingData = _context.Weathers.FirstOrDefault(x => x.City == city);
            if(existingData != null)
            {
                if((DateTime.Now - existingData.AddedTime).TotalMinutes > 30)
                {
                    _context.Weathers.UpdateRange(existingData, weather);
                    _context.SaveChanges();
                }
            }
        }
    }
}
