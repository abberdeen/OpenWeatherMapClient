using OpenWeatherMapClient.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models
{
    public class OneCallResponse
    {
        [JsonPropertyName("lat")]
        public double Lat { get; set; }

        [JsonPropertyName("lon")]
        public double Lon { get; set; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonPropertyName("timezone_offset")]
        public int TimezoneOffset { get; set; }

        [JsonPropertyName("current")]
        public Current Current { get; set; }

        [JsonPropertyName("minutely")]
        public List<Minutely> Minutely { get; set; }

        [JsonPropertyName("hourly")]
        public List<Hourly> Hourly { get; set; }

        [JsonPropertyName("daily")]
        public List<Daily> Daily { get; set; }

        [JsonPropertyName("alerts")]
        public List<Alert> Alerts { get; set; }
    }
}
