using System;

namespace OpenWeatherMapClient.Example
{
    class Program
    {
        static void Main(string[] args)
        {

            var apiKey = "3774078cb33ee37730c3be3ffc050b6f";
            var oneCallRequest = new OneCallRequest(apiKey);
            oneCallRequest.GetCurrentWeather(new Models.Base.Coordinates(21, 21));
            Console.ReadLine();
        }
    }
}
