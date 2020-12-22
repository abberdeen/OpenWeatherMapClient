using OpenWeatherMapClient.Models.Responses;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models
{
    public class MinutelyForecastWeatherData : BaseWeatherForecastData
    {
        /// <summary>
        /// Precipitation volume, mm
        /// </summary>
        [JsonPropertyName("precipitation")]
        public int Precipitation { get; set; }
    }
}