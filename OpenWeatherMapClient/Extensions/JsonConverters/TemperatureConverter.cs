using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models.Extension
{
    public class TemperatureConverter : JsonConverter<Temperature>
    {
        public override Temperature Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Number)
            {
                var val = reader.GetDouble();
                return Temperature.FromKelvin(reader.GetDouble());
            }
            return null;           
        }

        public override void Write(
            Utf8JsonWriter writer,
            Temperature temperature,
            JsonSerializerOptions options) =>
                writer.WriteStringValue(temperature.Kelvin.ToString());

        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(Temperature));
        }
    }
}
