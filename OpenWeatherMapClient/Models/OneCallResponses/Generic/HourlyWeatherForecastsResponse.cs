using OpenWeatherMapClient.Models.Base;
using OpenWeatherMapClient.Models.OneCallResponses;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models
{
    public class HourlyWeatherForecastsResponse : BaseResponse
    {

        /// <summary>
        /// Hourly forecast weather data API response
        /// </summary>
        [JsonPropertyName("hourly")]
        public List<HourForecastWeatherData> HourlyWeatherForecasts { get; set; }

    }
}