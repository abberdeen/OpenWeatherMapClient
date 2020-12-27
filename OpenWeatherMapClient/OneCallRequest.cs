using OpenWeatherMapClient.Models;
using OpenWeatherMapClient.Models.Base;
using OpenWeatherMapClient.Models.Enums;
using OpenWeatherMapClient.Models.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
        public OneCallRequest(string apiKey,
            Language language,
            UnitOfMeasurement unitOfMeasurement)
        {
            _apiKey = apiKey;
            _language = language;
            _unitOfMeasurement = unitOfMeasurement;
        }

        /// <summary>
        /// Use this method to get access to all one call api data (without history): 
        /// current weather, minute forecast for 1 hour, hourly forecast for 48 hours,
        /// daily forecast for 7 days and government weather alerts.
        /// 
        /// If you do not need all the data, it is better to use a specific call, for 
        /// example when you only need the current weather use the GetCurrentWeather()
        /// call instead.
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public OneCallResponse GetCurrentAndForecastWeatherData(Coordinates coordinates, List<Exclude> excludes = null)
        {
            var weatherForecast = OneCallDataDeserializer("");

            return weatherForecast;
        }

        /// <summary>
        /// Current weather data API response
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public CurrentWeatherResponse GetCurrentWeather(Coordinates coordinates)
        {
            var oneCallResponse = GetCurrentAndForecastWeatherData(coordinates, new List<Exclude>() { Exclude.Alerts, Exclude.Minutely, Exclude.Hourly, Exclude.Daily });
            var response = new CurrentWeatherResponse
            {
                Coordinates = oneCallResponse.Coordinates,
                Timezone = oneCallResponse.Timezone,
                TimezoneOffset = oneCallResponse.TimezoneOffset,
                Current = oneCallResponse.Current
            };
            return response;
        }

        /// <summary>
        /// Minute forecast weather data API response for 1 hour 
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public MinuteForecastWeatherResponse GetMinuteForecastWeather(Coordinates coordinates)
        {
            var oneCallResponse = GetCurrentAndForecastWeatherData(coordinates, new List<Exclude>() { Exclude.Alerts, Exclude.Current, Exclude.Hourly, Exclude.Daily });
            var response = new MinuteForecastWeatherResponse
            {
                Coordinates = oneCallResponse.Coordinates,
                Timezone = oneCallResponse.Timezone,
                TimezoneOffset = oneCallResponse.TimezoneOffset,
                Minutely = oneCallResponse.Minutely
            };
            return response;
        }

        /// <summary>
        ///  Hourly forecast weather data API response for 48 hours
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public HourlyForecastWeatherResponse GetHourlyForecastWeather(Coordinates coordinates)
        {
            var oneCallResponse = GetCurrentAndForecastWeatherData(coordinates, new List<Exclude>() { Exclude.Alerts, Exclude.Current, Exclude.Minutely, Exclude.Daily });
            var response = new HourlyForecastWeatherResponse
            {
                Coordinates = oneCallResponse.Coordinates,
                Timezone = oneCallResponse.Timezone,
                TimezoneOffset = oneCallResponse.TimezoneOffset,
                Hourly = oneCallResponse.Hourly
            };
            return response;
        }

        /// <summary>
        /// Daily forecast weather data API response 7 days
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public HourlyForecastWeatherResponse GetDailyForecastWeather(Coordinates coordinates)
        {
            var oneCallResponse = GetCurrentAndForecastWeatherData(coordinates, new List<Exclude>() { Exclude.Alerts, Exclude.Current, Exclude.Minutely, Exclude.Hourly });
            var response = new HourlyForecastWeatherResponse
            {
                Coordinates = oneCallResponse.Coordinates,
                Timezone = oneCallResponse.Timezone,
                TimezoneOffset = oneCallResponse.TimezoneOffset,
                Hourly = oneCallResponse.Hourly
            };
            return response;
        }

        private OneCallResponse OneCallDataDeserializer(string jsonResult)
        {
            var deserializeOptions = PrepareJsonSerializerOptions();
            var oneCallData = JsonSerializer.Deserialize<OneCallResponse>(jsonResult, deserializeOptions);
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