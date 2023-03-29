using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace WetherApp
{


    class RKIS
    {
        static void Main()
        {
            Console.Write("Введите название города: ");
            string city = Console.ReadLine();
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid=98702d12f45b79719ade61a0e6d3174e&units=metric&lang=ru";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
            Console.WriteLine($"Погода в {weatherResponse.Name}: {weatherResponse.Main.temp} °C, Описание погоды: {weatherResponse.Weather[0].description}, Облака-{weatherResponse.Weather[0].clouds}, Пасмурные облака-{weatherResponse.Weather[0].overcast_clouds},Скорость ветра-{weatherResponse.Weather[0].speed} м/c" );
        }
    }
}