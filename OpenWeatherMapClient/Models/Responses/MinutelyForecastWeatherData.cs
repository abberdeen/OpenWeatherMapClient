using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models
{
    public class MinutelyForecastWeatherData
    {
        [JsonPropertyName("dt")]
        public int Dt { get; set; }

        [JsonPropertyName("precipitation")]
        public int Precipitation { get; set; }
    }
}