using OpenWeatherMapClient.Models;
using OpenWeatherMapClient.Models.Extension;
using System;
using System.ComponentModel;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient
{
    public class OpenWeatherMapClient
    {
        public OpenWeatherMapClient()
        {
        }

        public OneCallData MakeOneCallRequest(string json)
        {

            var deserializeOptions = new JsonSerializerOptions();
            deserializeOptions.Converters.Add(new TemperatureConverter());
            deserializeOptions.Converters.Add(new UnixDateTimeConverter());
            deserializeOptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));

            var weatherForecast = JsonSerializer.Deserialize<OneCallData>(json, deserializeOptions);
            return weatherForecast;
        }
    }




}