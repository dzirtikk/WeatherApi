using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherAPI.Models;
using Newtonsoft.Json;

namespace WeatherAPI
{
    class Program
    {
        private const string AppKey = "e7413db58eeb82d26d4f842bef8e2a5d";
        static void Main(string[] args)
        {
            var client = new HttpClient();
            Console.WriteLine("Введите название города(На английском) температуру которого Вы хотите узнать: ");
            string city = Console.ReadLine();
            HttpResponseMessage response = client.GetAsync(new Uri($"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={AppKey}&units=metric&lang=ru")).GetAwaiter().GetResult();
            string jsonResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            var weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(jsonResult);

            Console.WriteLine($"Город: {weatherInfo.name}, температура: {weatherInfo.Main.temp}");

        }
    }
}
