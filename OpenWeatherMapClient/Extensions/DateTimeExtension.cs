using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeatherMapClient
{
    public static class DateTimeExtension
    {
        public static float UnixTimestamp(this DateTime dateTime)
        {
            long unixTime = ((DateTimeOffset)dateTime).ToUnixTimeSeconds();
            return unixTime;
        }
    }
}
