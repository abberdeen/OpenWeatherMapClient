using OpenWeatherMapClient.Models.Base;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models
{
    public class OneCallData
    {
        /// <summary>
        /// Geographical coordinates of the location (latitude)
        /// </summary>
        [JsonPropertyName("lat")]
        public double Latitude { get; set; }

        /// <summary>
        /// Geographical coordinates of the location (longitude)
        /// </summary>
        [JsonPropertyName("lon")]
        public double Longitude { get; set; }

        /// <summary>
        /// Timezone name for the requested location
        /// </summary>
        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// Shift in seconds from UTC
        /// </summary>
        [JsonPropertyName("timezone_offset")]
        public int TimezoneOffset { get; set; }

        /// <summary>
        /// Current weather data API response
        /// </summary>
        [JsonPropertyName("current")]
        public CurrentWeatherData Current { get; set; }

        /// <summary>
        /// Minute forecast weather data API response
        /// </summary>
        [JsonPropertyName("minutely")]
        public List<MinutelyForecastWeatherData> Minutely { get; set; }

        /// <summary>
        /// Hourly forecast weather data API response
        /// </summary>
        [JsonPropertyName("hourly")]
        public List<HourlyForecastWeatherData> Hourly { get; set; }

        /// <summary>
        /// Daily forecast weather data API response
        /// </summary>
        [JsonPropertyName("daily")]
        public List<DailyForecastWeatherData> Daily { get; set; }

        /// <summary>
        /// National weather alerts data from major national weather warning systems
        /// </summary>
        [JsonPropertyName("alerts")]
        public List<AlertData> Alerts { get; set; }
    }
}