using System.Text.Json.Serialization;

namespace _5_paskaita_web_API.Requests
{
    public class AirQuality
    {
        [JsonPropertyName("co")]
        public string Co { get; set; }

        [JsonPropertyName("no2")]
        public string No2 { get; set; }

        [JsonPropertyName("o3")]
        public string O3 { get; set; }

        [JsonPropertyName("so2")]
        public string So2 { get; set; }

        [JsonPropertyName("pm2_5")]
        public string Pm25 { get; set; }

        [JsonPropertyName("pm10")]
        public string Pm10 { get; set; }

        [JsonPropertyName("us-epa-index")]
        public string UsEpaIndex { get; set; }

        [JsonPropertyName("gb-defra-index")]
        public string GbDefraIndex { get; set; }
    }
}
