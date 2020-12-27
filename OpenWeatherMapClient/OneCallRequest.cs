using OpenWeatherMapClient.Models;
using OpenWeatherMapClient.Models.Base;
using OpenWeatherMapClient.Models.Enums;
using OpenWeatherMapClient.Models.Extension;
using System;
using System.ComponentModel;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient
{
    public class OneCallRequest
    {
        private string _apiKey;
        private Language _language;
        private UnitOfMeasurement _unitOfMeasurement;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey"></param>
        public OneCallRequest(string apiKey)
        {
            _apiKey = apiKey;
            _language = Language.English;
            _unitOfMeasurement = UnitOfMeasurement.Standard;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="language"></param>
        /// <param name="unitOfMeasurement"></param>
        public OneCallRequest(string apiKey, Language language, UnitOfMeasurement unitOfMeasurement)
        {
            _apiKey = apiKey;
            _language = language;
            _unitOfMeasurement = unitOfMeasurement;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public OneCallData MakeOneCallRequest(Coordinates coordinates)
        {
            var weatherForecast = OneCallDataDeserializer("");

            return weatherForecast;
        }

        private OneCallData OneCallDataDeserializer(string jsonResult)
        {
            var deserializeOptions = PrepareJsonSerializerOptions();
            var oneCallData = JsonSerializer.Deserialize<OneCallData>(jsonResult, deserializeOptions);
            return oneCallData;
        }

        private JsonSerializerOptions PrepareJsonSerializerOptions()
        {
            var deserializeOptions = new JsonSerializerOptions();
            deserializeOptions.Converters.Add(new TemperatureConverter());
            deserializeOptions.Converters.Add(new UnixDateTimeConverter());
            deserializeOptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
            return deserializeOptions;
        }
    }




}