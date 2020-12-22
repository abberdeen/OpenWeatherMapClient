using System;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models.Base
{
    public class WeatherCondition
    {
        /// <summary>
        /// Weather condition id
        /// Full list of weather condition codes: https://openweathermap.org/weather-conditions#Weather-Condition-Codes-2
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Group of weather parameters (Rain, Snow, Extreme etc.)
        /// </summary>
        [JsonPropertyName("main")]
        public WeatherConditionMain Main { get; set; }

        /// <summary>
        /// Weather condition within the group. Get the output in your language
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Weather icon id.
        /// </summary>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Uri to weather icon.
        /// </summary>
        public Uri IconUri { get { return new Uri($"http://openweathermap.org/img/wn/{Icon}@2x.png"); } }
    }

    /// <summary>
    /// Group of weather parameters 
    /// </summary>
    public enum WeatherConditionMain
    {
        Thunderstorm = 1,
        Drizzle = 2,
        Rain = 3,
        Snow = 4,
        Atmosphere = 5,
        Clear = 6,
        Clouds = 7
    }
}