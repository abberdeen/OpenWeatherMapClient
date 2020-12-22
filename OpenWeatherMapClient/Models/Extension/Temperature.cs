using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeatherMapClient
{
    /// <summary>
    /// 
    /// Explanation: https://stackoverflow.com/a/38904275/7199362
    /// Conversion table: https://contractorquotes.us/temperature-conversion-table/
    /// </summary>
    public class Temperature
    {
        private const double ABSOLUTE_ZERO = 273.15;
        private double _kelvin = 0.0;

        public double Kelvin
        {
            get { return _kelvin; }
            set { _kelvin = value; }
        }

        public double Fahrenheit
        { 
            get { return (_kelvin- ABSOLUTE_ZERO) * 9 / 5 + 32; }  /* convert Kelvin to Fahrenheit */
            set { _kelvin = (value - 32) * 5 / 9 + ABSOLUTE_ZERO; }  /* convert Fahrenheit to Kelvin */
        }

        public double Celsius
        {
            get { return _kelvin - ABSOLUTE_ZERO; } /* convert Kelvin to Celsius */
            set { _kelvin = value + ABSOLUTE_ZERO; } /* convert Celsius to Kelvin */
        }
         
        public static Temperature FromKelvin(double kelvin)
        {
            var temperature = new Temperature();
            temperature.Kelvin = kelvin;
            return temperature;
        }

        public static Temperature FromFahrenheit(double fahrenheit)
        {
            var temperature = new Temperature();
            temperature.Fahrenheit = fahrenheit;
            return temperature;
        }

        public static Temperature FromCelsius(double celsius)
        {
            var temperature = new Temperature();
            temperature.Celsius = celsius;
            return temperature;
        }
    }
}
