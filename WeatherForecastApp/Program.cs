using System;

namespace WeatherForecastApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weatherConditions = { "Sunny", "Cloudy", "Rainy", "Snowy", "Windy" };
            Random random = new Random();

            Console.WriteLine("Weather Forecast App");
            Console.WriteLine("----------------------");
            Console.WriteLine("Enter your city:");
            string city = Console.ReadLine();

            // Generate a random weather condition
            string weather = weatherConditions[random.Next(weatherConditions.Length)];
            Console.WriteLine($"The weather in {city} today is {weather}.");

            // Keep the console window open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
