using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class WeatherMap

    {
        public static double GetTemp(string apiCall)//this is a method used to get the temperature of the zipcode chosen
        {
            var client = new HttpClient();
            
            var response = client.GetStringAsync(apiCall).Result;
            
            var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());
            //creating a variable temp by accessing our temp from the main in postman and converting it to strings
            return temp; 
            //satisfying out return type in the method
        }
        public static double GetFeelsLike(string apiCall)//this is a method used to get the feelslike temp of the zipcode chosen
        {
            var client = new HttpClient();

            var response = client.GetStringAsync(apiCall).Result;

            var feelsLike = double.Parse(JObject.Parse(response)["main"]["feels_like"].ToString());
            //creating a variable temp by accessing our temp from the main in postman and converting it to strings
            return feelsLike;
            //satisfying out return type in the method
        }
        public static double GetTempMin(string apiCall)
        {
            var client = new HttpClient();
            var response = client.GetStringAsync(apiCall).Result;
            var tempMin = double.Parse(JObject.Parse(response)["main"]["temp_min"].ToString());
            return tempMin;
     
        }
        public static double GetTempMax(string apiCall)
        {
            var client = new HttpClient();
            var response = client.GetStringAsync(apiCall).Result;
            var tempMax = double.Parse(JObject.Parse(response)["main"]["temp_max"].ToString());
            return tempMax;

        }
        public static double GetHumidity(string apiCall)
        {
            var client = new HttpClient();
            var response = client.GetStringAsync(apiCall).Result;
            var humidity = double.Parse(JObject.Parse(response)["main"]["humidity"].ToString());
            return humidity;
        }
    }
}
