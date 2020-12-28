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
        public CurrentWeather CurrentWeather { get; set; }

        /// <summary>
        /// Minute forecast weather data API response
        /// </summary>
        [JsonPropertyName("minutely")]
        public List<MinuteForecastWeather> MinuteWeatherForecasts { get; set; }

        /// <summary>
        /// Hourly forecast weather data API response
        /// </summary>
        [JsonPropertyName("hourly")]
        public List<HourForecastWeatherData> HourlyWeatherForecasts { get; set; }

        /// <summary>
        /// Daily forecast weather data API response
        /// </summary>
        [JsonPropertyName("daily")]
        public List<DailyForecastWeather> DailyWeatherForecasts { get; set; }

        /// <summary>
        /// National weather alerts data from major national weather warning systems
        /// </summary>
        [JsonPropertyName("alerts")]
        public List<AlertResponse> Alerts { get; set; }
    }
}