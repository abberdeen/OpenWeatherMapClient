using OpenWeatherMapClient.Models.Base;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models.Responses
{
    public class BaseWeatherForecastData
    {

        private UnitOfMeasurement _unitOfMeasurement;

        /*
         public BaseWeatherForecastData(UnitOfMeasurement unitOfMeasurement) 
        {
            _unitOfMeasurement = unitOfMeasurement;
        }*/

        /// <summary>
        /// Time of the forecasted data, Unix, UTC
        /// </summary>
        [JsonPropertyName("dt")]
        public int DateTimeUnix { get; set; }

        /// <summary>
        /// Time of the forecasted data, UTC
        /// </summary>
        public DateTime DateTime
        {
            get
            {
                DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                dtDateTime = dtDateTime.AddSeconds(DateTimeUnix).ToLocalTime();
                return dtDateTime;
            }
        }

        /// <summary>
        /// Atmospheric pressure on the sea level, hPa 
        /// </summary>
        [JsonPropertyName("pressure")]
        public int Pressure { get; set; }

        /// <summary>
        /// Humidity, %
        /// </summary>
        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }

        /// <summary>
        /// Atmospheric temperature (varying according to pressure and humidity) below which water droplets begin to condense and dew can form.
        /// </summary>
        [JsonPropertyName("dew_point")]
        public double DewPoint { get; set; }

        /// <summary>
        /// Cloudiness, %
        /// </summary>
        [JsonPropertyName("clouds")]
        public int Clouds { get; set; }

        /// <summary>
        /// Wind speed.
        /// </summary>
        [JsonPropertyName("wind_speed")]
        public double WindSpeed { get; set; }

        /// <summary>
        /// (where available) Wind gust. Wind speed.
        /// </summary>
        [JsonPropertyName("wind_gust")]
        public double? WindGust { get; set; }

        /// <summary>
        /// Wind direction, degrees (meteorological)
        /// </summary>
        [JsonPropertyName("wind_deg")]
        public int WindDeg { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("weather")]
        public List<WeatherCondition> Weather { get; set; }
    }
}