using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models.Base
{
    public class Rain
    {
        /// <summary>
        /// Rain volume for last hour, mm
        /// </summary>
        [JsonPropertyName("1h")]
        public double? LastHour { get; set; }
    }
}
