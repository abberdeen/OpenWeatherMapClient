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
        /// Temperature. This accounts for the human perception of weather. 
        /// </summary>
        [JsonPropertyName("feels_like")]
        public double FeelsLike { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("pressure")]
        public int Pressure { get; set; }

        /// <summary>
        /// Atmospheric pressure on the sea level, hPa
        /// </summary>
        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }

        /// <summary>
        /// Humidity, %
        /// </summary>
        [JsonPropertyName("dew_point")]
        public double DewPoint { get; set; }

        /// <summary>
        /// Midday UV index
        /// </summary>
        [JsonPropertyName("uvi")]
        public int Uvi { get; set; }

        /// <summary>
        /// Cloudiness, %
        /// </summary>
        [JsonPropertyName("clouds")]
        public int Clouds { get; set; }

        /// <summary>
        /// Average visibility, metres
        /// </summary>
        [JsonPropertyName("visibility")]
        public int Visibility { get; set; }

        /// <summary>
        /// Wind speed.
        /// </summary>
        [JsonPropertyName("wind_speed")]
        public double WindSpeed { get; set; }

        ///
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
        /// Precipitation volume, mm
        /// </summary>
        [JsonPropertyName("rain")]
        public int Rain { get; set; }

        /// <summary>
        /// Snow volume, mm
        /// </summary>
        [JsonPropertyName("snow")]
        public int Snow { get; set; }

        /// <summary>
        /// Wind direction, degrees (meteorological)
        /// </summary>
        [JsonPropertyName("weather")]
        public List<Weather> Weather { get; set; }
    }
}