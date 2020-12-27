using OpenWeatherMapClient.Models.Base;
using OpenWeatherMapClient.Models.OneCallResponses;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models
{
    public class OneCallResponse : BaseResponse
    { 
        /// <summary>
        /// Current weather data API response
        /// </summary>
        [JsonPropertyName("current")]
        public CurrentWeather Current { get; set; }

        /// <summary>
        /// Minute forecast weather data API response
        /// </summary>
        [JsonPropertyName("minutely")]
        public List<MinuteForecastWeather> Minutely { get; set; }

        /// <summary>
        /// Hourly forecast weather data API response
        /// </summary>
        [JsonPropertyName("hourly")]
        public List<HourForecastWeatherData> Hourly { get; set; }

        /// <summary>
        /// Daily forecast weather data API response
        /// </summary>
        [JsonPropertyName("daily")]
        public List<DailyForecastWeather> Daily { get; set; }

        /// <summary>
        /// National weather alerts data from major national weather warning systems
        /// </summary>
        [JsonPropertyName("alerts")]
        public List<Alert> Alerts { get; set; }
    }
}