using OpenWeatherMapClient.Models.Base;
using OpenWeatherMapClient.Models.Responses;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models
{
    /// <summary>
    ///  Current weather data API response
    /// </summary>
    public class CurrentWeatherData : BaseWeatherForecastData
    { 
        /// <summary>
        ///  Sunrise time, Unix, UTC
        /// </summary>
        [JsonPropertyName("sunrise")]
        public int Sunrise { get; set; }

        /// <summary>
        ///  Sunset time, Unix, UTC
        /// </summary>
        [JsonPropertyName("sunset")]
        public int Sunset { get; set; }

        /// <summary>
        /// Temperature.  
        /// </summary>
        [JsonPropertyName("temp")]
        public double Temperature { get; set; } 

        /// <summary>
        /// Temperature. This accounts for the human perception of weather. 
        /// </summary>
        [JsonPropertyName("feels_like")]
        public double FeelsLike { get; set; }

        /// <summary>
        /// Current UV index
        /// </summary>
        [JsonPropertyName("uvi")]
        public int Uvi { get; set; }
         
        /// <summary>
        /// Average visibility, metres
        /// </summary>
        [JsonPropertyName("visibility")]
        public int Visibility { get; set; }
                    
        /// <summary>
        /// Rain
        /// </summary>
        [JsonPropertyName("rain")]
        public Rain Rain { get; set; }

        /// <summary>
        /// Snow
        /// </summary>
        [JsonPropertyName("snow")]
        public Snow Snow { get; set; } 
    }
}