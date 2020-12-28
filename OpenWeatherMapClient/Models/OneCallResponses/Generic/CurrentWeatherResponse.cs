using OpenWeatherMapClient.Models.Base;
using OpenWeatherMapClient.Models.OneCallResponses;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models
{
    public class CurrentWeatherResponse : BaseResponse
    { 

        /// <summary>
        /// Current weather data API response
        /// </summary>
        [JsonPropertyName("current")]
        public CurrentWeather CurrentWeather { get; set; }
        
    }
}