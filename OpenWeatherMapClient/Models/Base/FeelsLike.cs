using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models.Base
{
    public class FeelsLike
    {
        /// <summary>
        /// Morning temperature.
        /// </summary>
        [JsonPropertyName("morn")]
        public double Morn { get; set; }

        /// <summary>
        /// Day temperature.
        /// </summary>
        [JsonPropertyName("day")]
        public double Day { get; set; }

        /// <summary>
        /// Evening temperature.
        /// </summary>
        [JsonPropertyName("eve")]
        public double Eve { get; set; }

        /// <summary>
        /// Night temperature.
        /// </summary>
        [JsonPropertyName("night")]
        public double Night { get; set; } 
    }
}