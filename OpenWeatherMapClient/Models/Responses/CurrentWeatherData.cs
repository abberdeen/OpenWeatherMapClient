using OpenWeatherMapClient.Models.Base;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models
{
    /// <summary>
    ///  Current weather data API response
    /// </summary>
    public class CurrentWeatherData
    {
        /// <summary>
        /// Current time, Unix, UTC
        /// </summary>
        [JsonPropertyName("dt")]
        public int Dt { get; set; }

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
        /// Temperature. Units - default: kelvin, metric: Celsius, imperial: Fahrenheit. How to change units used
        /// </summary>
        [JsonPropertyName("temp")]
        public double Temperature { get; set; }

        /// <summary>
        ///
        /// </summary>
        public UnitOfTemperature UnitOfTemperature { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("feels_like")]
        public double FeelsLike { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("pressure")]
        public int Pressure { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("dew_point")]
        public double DewPoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("uvi")]
        public int Uvi { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("clouds")]
        public int Clouds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("visibility")]
        public int Visibility { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("wind_speed")]
        public double WindSpeed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("wind_deg")]
        public int WindDeg { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("weather")]
        public List<Weather> Weather { get; set; }
    }
}