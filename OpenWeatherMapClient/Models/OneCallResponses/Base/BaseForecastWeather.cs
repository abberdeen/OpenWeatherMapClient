using OpenWeatherMapClient.Models.Base;
using OpenWeatherMapClient.Models.Extension;
using OpenWeatherMapClient.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models.Responses
{
    /// <summary>
    
    /// </summary>
    public class BaseWeatherForecastData
    {

        /// <summary>
        /// Time of the forecasted data, UTC
        /// </summary>
        [JsonPropertyName("dt")] 
        public DateTime DateTime { get; set; }
         
        /// <summary>
        /// Atmospheric pressure on the sea level, hPa 
        /// </summary>
        [JsonPropertyName("pressure")]
        public double Pressure { get; set; }

        /// <summary>
        /// Humidity, %
        /// </summary>
        [JsonPropertyName("humidity")]
        public double Humidity { get; set; }

        /// <summary>
        /// Atmospheric temperature (varying according to pressure and humidity) below which water droplets begin to condense and dew can form.
        /// </summary>
        [JsonPropertyName("dew_point")]
        public Temperature DewPoint { get; set; }

        /// <summary>
        /// Cloudiness, %
        /// </summary>
        [JsonPropertyName("clouds")]
        public double Clouds { get; set; }

        /// <summary>
        /// Wind speed.
        /// </summary>
        [JsonPropertyName("wind_speed")]
        public Speed WindSpeed { get; set; }

        /// <summary>
        /// (where available) Wind gust. Wind speed.
        /// </summary>
        [JsonPropertyName("wind_gust")]
        public Speed? WindGust { get; set; }

        /// <summary>
        /// Wind direction, degrees (meteorological)
        /// </summary>
        [JsonPropertyName("wind_deg")]
        public double WindDeg { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("weather")]
        public List<WeatherCondition> Weather { get; set; }
    }
}