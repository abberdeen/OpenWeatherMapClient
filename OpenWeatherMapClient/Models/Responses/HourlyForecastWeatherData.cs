﻿using OpenWeatherMapClient.Models.Base;
using OpenWeatherMapClient.Models.Responses;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models
{
    /// <summary>
    /// Hourly forecast weather data API response
    /// </summary>
    public class HourlyForecastWeatherData : BaseWeatherForecastData
    {
        /// <summary>
        /// Temperature
        /// </summary>
        [JsonPropertyName("temp")]
        public double Temperature { get; set; }

        /// <summary>
        /// Temperature. This accounts for the human perception of weather.
        /// </summary>
        [JsonPropertyName("feels_like")]
        public double FeelsLike { get; set; }

        /// <summary>
        /// UV index
        /// </summary>
        [JsonPropertyName("uvi")]
        public double Uvi { get; set; }

        /// <summary>
        /// Average visibility, metres
        /// </summary>
        [JsonPropertyName("visibility")]
        public int Visibility { get; set; }

        /// <summary>
        /// Probability of precipitation
        /// </summary>
        [JsonPropertyName("pop")]
        public double Pop { get; set; }

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