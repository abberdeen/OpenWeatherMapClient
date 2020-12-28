using OpenWeatherMapClient.Models.Base;
using OpenWeatherMapClient.Models.OneCallResponses;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models
{
    public class MinuteWeatherForecastsResponse : BaseResponse
    {

        /// <summary>
        /// Minute forecast weather data API response
        /// </summary>
        [JsonPropertyName("minutely")]
        public List<MinuteForecastWeather> MinuteWeatherForecasts { get; set; }

    }
}