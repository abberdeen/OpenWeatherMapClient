using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models.Base
{
    public class AlertData
    {
        [JsonPropertyName("sender_name")]
        public string SenderName { get; set; }

        [JsonPropertyName("event")]
        public string Event { get; set; }

        [JsonPropertyName("start")]
        public int Start { get; set; }

        [JsonPropertyName("end")]
        public int End { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}