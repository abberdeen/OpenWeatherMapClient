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
using System.Security.Cryptography.X509Certificates;
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
        public OneCallRequest(string apiKey, Language language)
        {
            _apiKey = apiKey;
            _language = language;
            _unitOfMeasurement = UnitOfMeasurement.Standard;
        }

        private string GetRequestUri(Coordinates coordinates, List<Exclude> excludes = null)
        {
            var excludeParts = excludes == null ? "" : String.Join(", ", excludes.ToArray()).ToLower();
            var units = _unitOfMeasurement.ToString().ToLower();
            var uri = $"https://api.openweathermap.org/data/2.5/onecall?" +
                $"lat={coordinates.Latitude}&" +
                $"lon={coordinates.Longitude}&" +
                $"exclude={excludeParts}&" +
                $"appid={_apiKey}&" +
                $"units={units}&" +
                $"lang={_language.LanguageCode}";
            return uri;
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
        public OneCallResponse GetCurrentAndForecastWeather(Coordinates coordinates, List<Exclude> excludes = null)
        {
            var rawJson = GetCurrentAndForecastWeatherRawJson(coordinates, excludes);
            var weatherForecast = OneCallDataDeserializer(rawJson);
            return weatherForecast;
        }

        public string GetCurrentAndForecastWeatherRawJson(Coordinates coordinates, List<Exclude> excludes = null)
        {
            var oneCallUri = GetRequestUri(coordinates, excludes);
            using (var client = new System.Net.WebClient())
            {
                try
                {
                    var jsonResponse = client.DownloadString(oneCallUri);
                    return jsonResponse;
                }
                catch (System.Net.WebException)
                {

                    throw new OpenWeatherMapAPIException();
                }
            }
        }

        /// <summary>
        /// Current weather data API response
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public CurrentWeatherResponse GetCurrentWeather(Coordinates coordinates)
        {
            var oneCallResponse = GetCurrentAndForecastWeather(coordinates, new List<Exclude>() { Exclude.Alerts, Exclude.Minutely, Exclude.Hourly, Exclude.Daily });
            var response = new CurrentWeatherResponse
            {
                Latitude = oneCallResponse.Latitude,
                Longitude = oneCallResponse.Longitude,
                Timezone = oneCallResponse.Timezone,
                TimezoneOffset = oneCallResponse.TimezoneOffset,
                CurrentWeather = oneCallResponse.CurrentWeather
            };
            return response;
        }

        /// <summary>
        /// Minute forecast weather data API response for 1 hour 
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public MinuteWeatherForecastsResponse GetMinuteForecastWeather(Coordinates coordinates)
        {
            var oneCallResponse = GetCurrentAndForecastWeather(coordinates, new List<Exclude>() { Exclude.Alerts, Exclude.Current, Exclude.Hourly, Exclude.Daily });
            var response = new MinuteWeatherForecastsResponse
            {
                Latitude = oneCallResponse.Latitude,
                Longitude = oneCallResponse.Longitude,
                Timezone = oneCallResponse.Timezone,
                TimezoneOffset = oneCallResponse.TimezoneOffset,
                MinuteWeatherForecasts = oneCallResponse.MinuteWeatherForecasts
            };
            return response;
        }

        /// <summary>
        ///  Hourly forecast weather data API response for 48 hours
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public HourlyWeatherForecastsResponse GetHourlyForecastWeather(Coordinates coordinates)
        {
            var oneCallResponse = GetCurrentAndForecastWeather(coordinates, new List<Exclude>() { Exclude.Alerts, Exclude.Current, Exclude.Minutely, Exclude.Daily });
            var response = new HourlyWeatherForecastsResponse
            {
                Latitude = oneCallResponse.Latitude,
                Longitude = oneCallResponse.Longitude,
                Timezone = oneCallResponse.Timezone,
                TimezoneOffset = oneCallResponse.TimezoneOffset,
                HourlyWeatherForecasts = oneCallResponse.HourlyWeatherForecasts
            };
            return response;
        }

        /// <summary>
        /// Daily forecast weather data API response 7 days
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public DailyWeatherForecastsResponse GetDailyForecastWeather(Coordinates coordinates)
        {
            var oneCallResponse = GetCurrentAndForecastWeather(coordinates, new List<Exclude>() { Exclude.Alerts, Exclude.Current, Exclude.Minutely, Exclude.Hourly });
            var response = new DailyWeatherForecastsResponse
            {
                Latitude = oneCallResponse.Latitude,
                Longitude = oneCallResponse.Longitude,
                Timezone = oneCallResponse.Timezone,
                TimezoneOffset = oneCallResponse.TimezoneOffset,
                DailyWeatherForecasts = oneCallResponse.DailyWeatherForecasts
            };
            return response;
        }

        public OneCallResponse OneCallDataDeserializer(string jsonResult)
        {
            var deserializeOptions = PrepareJsonSerializerOptions();
            var oneCallData = JsonSerializer.Deserialize<OneCallResponse>(jsonResult, deserializeOptions);
            return oneCallData;
        }

        private JsonSerializerOptions PrepareJsonSerializerOptions()
        {
            var deserializeOptions = new JsonSerializerOptions();
            deserializeOptions.Converters.Add(new TemperatureConverter());
            deserializeOptions.Converters.Add(new SpeedConverter());
            deserializeOptions.Converters.Add(new UnixDateTimeConverter());
            deserializeOptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
            return deserializeOptions;
        }
    }




}