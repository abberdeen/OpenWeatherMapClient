using OpenWeatherMapClient.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models.OneCallResponses
{
    public class BaseResponse
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
        
    }
}
