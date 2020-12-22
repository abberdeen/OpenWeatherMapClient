using OpenWeatherMapClient.Models.Base;
using OpenWeatherMapClient.Models.Extension;
using OpenWeatherMapClient.Models.Responses;
using System;
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
        ///  Sunrise time, UTC
        /// </summary>
        [JsonPropertyName("sunrise")]
        public DateTime Sunrise { get; set; }

        /// <summary>
        ///  Sunset time, UTC
        /// </summary>
        [JsonPropertyName("sunset")]
        public DateTime Sunset { get; set; }

        /// <summary>
        /// Temperature.  
        /// </summary>
        [JsonPropertyName("temp")] 
        public Temperature Temp { get; set; } 

        /// <summary>
        /// Temperature. This accounts for the human perception of weather. 
        /// </summary>
        [JsonPropertyName("feels_like")] 
        public Temperature FeelsLike { get; set; }

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