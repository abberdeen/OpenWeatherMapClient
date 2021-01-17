using OpenWeatherMapClient.Types;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models.Extension
{
    public class SpeedConverter : JsonConverter<Speed>
    {
        public override Speed Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Number)
            {
                var val = reader.GetDouble();
                return Speed.FromMeterPerSecond(reader.GetDouble());
            }
            return null;           
        }

        public override void Write(
            Utf8JsonWriter writer,
            Speed speed,
            JsonSerializerOptions options)
        {
            writer.WriteStringValue(speed.MetresPerSecond.ToString());
        }

        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(Speed));
        }
    }
}
