﻿using OpenWeatherMapClient.Models.Responses;
using System;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models
{
    public class MinuteForecastWeather
    {
        /// <summary>
        /// Time of the forecasted data, UTC
        /// </summary>
        [JsonPropertyName("dt")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Precipitation volume, mm
        /// </summary>
        [JsonPropertyName("precipitation")]
        public double Precipitation { get; set; }
    }
}