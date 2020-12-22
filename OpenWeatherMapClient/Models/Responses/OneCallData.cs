using OpenWeatherMapClient.Models.Base;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models
{
    public class OneCallData
    {
        [JsonPropertyName("lat")]
        public double Lat { get; set; }

        [JsonPropertyName("lon")]
        public double Lon { get; set; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonPropertyName("timezone_offset")]
        public int TimezoneOffset { get; set; }

        [JsonPropertyName("current")]
        public CurrentWeatherData Current { get; set; }

        [JsonPropertyName("minutely")]
        public List<MinutelyForecastWeatherData> Minutely { get; set; }

        [JsonPropertyName("hourly")]
        public List<HourlyForecastWeatherData> Hourly { get; set; }

        [JsonPropertyName("daily")]
        public List<DailyForecastWeatherData> Daily { get; set; }

        [JsonPropertyName("alerts")]
        public List<AlertData> Alerts { get; set; }
    }
}