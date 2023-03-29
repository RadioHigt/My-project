using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace WetherApp
{
    class WeatherResponse
    {
        public TemperatureInfo Main { get; set; }
        public WeatherInfo[] Weather { get; set; }
        public string Name { get; set; }
    }
}