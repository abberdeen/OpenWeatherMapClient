using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OpenWeatherMapClient.Models.Base
{
    public class Coordinates
    {
        public Coordinates() { }

        public Coordinates(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        } 
         
        public double Latitude { get; set; } 

        public double Longitude { get; set; }
    }
}
