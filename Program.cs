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
            //storing JSON file in the variable key
            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();
            //Calling Jobject class and parsing "key" and useing GetValue() of 
            //appsettings APIKey

            Console.WriteLine("Please enter your ZipCode");
            //Asking the user to enter zip code and storing it in zipCode
            var zipCode = Console.ReadLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIKey}";
            //apiCall is the URL from PostMan. Updating the zipCode value from what the user enters.
            //Also adding APIkey to hide my API key by using our variable APIKey
            Console.WriteLine();

            Console.WriteLine($"The current weather for this location is:");
            Console.WriteLine();
            Console.WriteLine($"Current Temp: {WeatherMap.GetTemp(apiCall)} degrees F");
            Console.WriteLine($"Feels like: {WeatherMap.GetFeelsLike(apiCall)}");
            Console.WriteLine($"Temp Min: {WeatherMap.GetTempMin(apiCall)}");
            Console.WriteLine($"Temp Max: {WeatherMap.GetTempMax(apiCall)}");
            Console.WriteLine($"Humidity: {WeatherMap.GetHumidity(apiCall)}");

            //Using the class WeatherMapTemp to put in the temp of the location zipcode the user chose
            
            Console.WriteLine($"This is the weather for the zipcode {zipCode} you entered");

        }
    }
}