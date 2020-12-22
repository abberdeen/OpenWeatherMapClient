using OpenWeatherMapClient.Models.Extension;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models.Base
{
    public class DailyTemperature
    {
        /// <summary>
        /// Min daily temperature.
        /// </summary>
        [JsonPropertyName("min")] 
        public double Min { get; set; }

        /// <summary>
        /// Max daily temperature.
        /// </summary>
        [JsonPropertyName("max")] 
        public double Max { get; set; }

        /// <summary>
        /// Morning temperature.
        /// </summary>
        [JsonPropertyName("morn")] 
        public Temperature Morn { get; set; }

        /// <summary>
        /// Day temperature.
        /// </summary>
        [JsonPropertyName("day")] 
        public Temperature Day { get; set; }

        /// <summary>
        /// Evening temperature.
        /// </summary>
        [JsonPropertyName("eve")] 
        public Temperature Eve { get; set; }

        /// <summary>
        /// Night temperature.
        /// </summary>
        [JsonPropertyName("night")] 
        public Temperature Night { get; set; }

    }
}