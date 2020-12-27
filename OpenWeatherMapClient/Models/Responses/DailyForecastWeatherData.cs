using OpenWeatherMapClient.Models.Base;
using OpenWeatherMapClient.Models.Extension;
using OpenWeatherMapClient.Models.Responses;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models
{
    /// <summary>
    /// Daily forecast weather data API response
    /// </summary>
    public class DailyForecastWeatherData : BaseWeatherForecastData
    { 
        /// <summary>
        ///  Sunrise time, UTC
        /// </summary>
        [JsonPropertyName("sunrise")]
        public DateTime Sunrise { get; set; }

        /// <summary>
        /// Sunset time, UTC
        /// </summary>
        [JsonPropertyName("sunset")]
        public DateTime Sunset { get; set; }

        /// <summary>
        /// Daily temperatures
        /// </summary>
        [JsonPropertyName("temp")] 
        public DailyTemperature Temp { get; set; }

        /// <summary>
        /// This accounts for the human perception of weather.
        /// </summary>
        [JsonPropertyName("feels_like")]
        public FeelsLike FeelsLike { get; set; } 

        /// <summary>
        /// Probability of precipitation
        /// </summary>
        [JsonPropertyName("pop")]
        public double Pop { get; set; }

        /// <summary>
        /// The maximum value of UV index for the day
        /// </summary>
        [JsonPropertyName("uvi")]
        public double Uvi { get; set; }

        /// <summary>
        /// Precipitation volume, mm
        /// </summary>
        [JsonPropertyName("rain ")]
        public double? Rain { get; set; }

        /// <summary>
        /// Snow volume, mm
        /// </summary>
        [JsonPropertyName("snow")]
        public double? Snow { get; set; }
    }
}