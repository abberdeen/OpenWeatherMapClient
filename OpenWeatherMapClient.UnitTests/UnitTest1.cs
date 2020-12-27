using NUnit.Framework;
using OpenWeatherMapClient.Types;

namespace OpenWeatherMapClient.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        } 

        [Test]
        public void TestSpeed()
        {
            // Creating speed from miles per hour
            var milesPerHour = 2.237136;
            var speed1 = Speed.FromMilesPerHour(milesPerHour);
            Assert.AreEqual(milesPerHour, speed1.MilesPerHour, 3);
            Assert.AreEqual(1, speed1.MetresPerSecond, 3);

            // Creating speed from miles per hour
            var metersPerSecond = 2.237136;
            var speed2 = Speed.FromMeterPerSecond(metersPerSecond);
            Assert.AreEqual(milesPerHour, speed2.MetresPerSecond, 3);
        }
    }
}