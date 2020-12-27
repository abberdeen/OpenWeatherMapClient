using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeatherMapClient.Models.Enums
{
    /// <summary>
    /// By using this parameter you can exclude some parts of the weather data from the API response. 
    /// </summary>
    public enum Exclude
    {
        Current = 1,
        Minutely = 2,
        Hourly = 3,
        Daily = 4,
        Alerts = 5
    }
}
