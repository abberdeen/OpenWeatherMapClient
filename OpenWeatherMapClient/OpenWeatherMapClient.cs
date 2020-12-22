using System;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient
{
    public class OpenWeatherMapClient 
    {
        public OpenWeatherMapClient() 
        {
        }

        public void MakeOneCallRequest() 
        {

        }
    }

    public class Snow
    {
        [JsonPropertyName("1h")]
        public double _1h { get; set; }
    }


}