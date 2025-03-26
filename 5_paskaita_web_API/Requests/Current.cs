using _5_paskaita_web_API.Responses;
using System.Text.Json.Serialization;

namespace _5_paskaita_web_API.Requests
{
    public class Current
    {
        [JsonPropertyName("observation_time")]
        public string ObservationTime { get; set; }

        public int Temperature { get; set; }

        [JsonPropertyName("weather_code")]
        public int WeatherCode { get; set; }

        [JsonPropertyName("weather_icons")]
        public List<string> WeatherIcons { get; set; }

        [JsonPropertyName("weather_descriptions")]
        public List<string> WeatherDescriptions { get; set; }

        public Astro Astro { get; set; }

        [JsonPropertyName("air_quality")]
        public AirQuality AirQuality { get; set; }

        [JsonPropertyName("wind_speed")]
        public int WindSpeed { get; set; }

        [JsonPropertyName("wind_degree")]
        public int WindDegree { get; set; }

        [JsonPropertyName("wind_dir")]
        public string WindDir { get; set; }

        public int Pressure { get; set; }
        public int Precip { get; set; }
        public int Humidity { get; set; }
        public int Cloudcover { get; set; }
        public int Feelslike { get; set; }

        [JsonPropertyName("uv_index")]
        public int UvIndex { get; set; }

        public int Visibility { get; set; }

        [JsonPropertyName("is_day")]
        public string IsDay { get; set; }
    }
}
