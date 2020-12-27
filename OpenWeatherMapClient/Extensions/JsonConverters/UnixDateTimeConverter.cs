using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models.Extension
{
    public class UnixDateTimeConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options) =>
               FromUnixTimeStamp(reader.GetDouble());

        public override void Write(
            Utf8JsonWriter writer,
            DateTime dateTime,
            JsonSerializerOptions options)
        {
            var unixTimeSeconds = ((DateTimeOffset)dateTime).ToUnixTimeSeconds();
            writer.WriteStringValue(unixTimeSeconds.ToString());
        }

        private DateTime FromUnixTimeStamp(double dateTimeUnix)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(dateTimeUnix).ToLocalTime();
            return dtDateTime;
        }
    }
}
