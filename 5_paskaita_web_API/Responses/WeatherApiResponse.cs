using _5_paskaita_web_API.Requests;
using System.Text.Json.Serialization;

namespace _5_paskaita_web_API.Responses
{
        public class WeatherApiResponse
        {
            public Request Request { get; set; }
            public Location Location { get; set; }
            public Current Current { get; set; }
        }
}
