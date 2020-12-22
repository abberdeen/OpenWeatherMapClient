using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models
{
    public class Minutely
    {
        [JsonPropertyName("dt")]
        public int Dt { get; set; }

        [JsonPropertyName("precipitation")]
        public int Precipitation { get; set; }
    }

}
