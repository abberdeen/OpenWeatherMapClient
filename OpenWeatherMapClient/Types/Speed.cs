using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeatherMapClient.Types
{
    public class Speed
    { 
        private double _metresPerSecond = 0.0;

        public double MetresPerSecond
        {
            get { return _metresPerSecond; }
            set { _metresPerSecond = value; }
        }

        public double MilesPerHour
        {
            get { return _metresPerSecond * 2.237136; }
            set { _metresPerSecond = value / 2.237136; }
        }

        public static Speed FromMeterPerSecond(double meterPerSecond)
        {
            var speed = new Speed();
            speed.MetresPerSecond = meterPerSecond;
            return speed;
        }

        public static Speed FromMilesPerHour(double milesPerHour)
        {
            var speed = new Speed();
            speed.MilesPerHour = milesPerHour;
            return speed;
        }

    }
}
