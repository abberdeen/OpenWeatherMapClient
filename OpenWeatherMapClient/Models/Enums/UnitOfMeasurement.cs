namespace OpenWeatherMapClient.Models.Base
{
    /// <summary>
    /// Temperature is available in Fahrenheit, Celsius and Kelvin units.
    /// Wind speed is available in miles/hour and meter/sec.
    /// </summary>
    public enum UnitOfMeasurement
    {
        /// <summary>
        /// Loads data from API as:  Default. Temperature in Kelvin and wind speed in meter/sec is
        /// </summary>
        Standard = 1,

        /// <summary>
        /// Loads data from API as: Temperature in Celsius and wind speed in meter/sec
        /// </summary>
        Metric = 2,

        /// <summary>
        /// Loads data from API as:  Temperature in Fahrenheit and wind speed in miles/hour
        /// </summary>
        Imperial = 3,
    }
}