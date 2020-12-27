using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models.Base
{
    public class Coordinates
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
    }
}
