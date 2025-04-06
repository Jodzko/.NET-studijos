using System.ComponentModel.DataAnnotations;

namespace _5_paskaita_web_API.Models
{
    public class WeatherData
    {
        [Key]
        public string City { get; set; }
        public DateTime AddedTime { get; set; }
        public string AllData { get; set; }

        public WeatherData(string city, string allData)
        {
            City = city;
            AddedTime = DateTime.Now;
            AllData = allData;
        }
    }
}
