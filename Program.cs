using Newtonsoft.Json.Linq;
using System.Globalization;
using System.IO;

namespace WeatherApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("appsettings.json");
            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

            Console.WriteLine("Please enter your ZipCode");
            var zipCode = Console.ReadLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIKey}";

            Console.WriteLine();

            Console.WriteLine($"It is currently {WeatherMapTemp.GetTemp(apiCall)} degrees F in your loacation");
            
            Console.WriteLine("If your temp is less that 40 degrees F, YOU NEED TO MOVE SOUTH");

        }
    }
}