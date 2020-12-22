using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models.Base
{
    /// <summary>
    /// National weather alerts data from major national weather warning systems
    /// </summary>
    public class AlertData
    {
        /// <summary>
        /// Name of the alert source. Please read here the full list of alert sources: https://openweathermap.org/api/one-call-api#listsource
        /// </summary>
        [JsonPropertyName("sender_name")]
        public string SenderName { get; set; }

        /// <summary>
        /// Alert event name
        /// </summary>
        [JsonPropertyName("event")]
        public string Event { get; set; }

        /// <summary>
        /// Date and time of the start of the alert, Unix, UTC
        /// </summary>
        [JsonPropertyName("start")]
        public int Start { get; set; }

        /// <summary>
        /// Date and time of the end of the alert, Unix, UTC
        /// </summary>
        [JsonPropertyName("end")]
        public int End { get; set; }

        /// <summary>
        /// Description of the alert
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}