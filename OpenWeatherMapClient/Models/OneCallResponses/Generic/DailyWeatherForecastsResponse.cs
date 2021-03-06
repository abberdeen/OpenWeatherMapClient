﻿using OpenWeatherMapClient.Models.Base;
using OpenWeatherMapClient.Models.OneCallResponses;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models
{
    public class DailyWeatherForecastsResponse : BaseResponse
    {

        /// <summary>
        /// Daily forecast weather data API response
        /// </summary>
        [JsonPropertyName("daily")]
        public List<DailyForecastWeather> DailyWeatherForecasts { get; set; }

    }
}