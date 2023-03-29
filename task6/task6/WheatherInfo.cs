using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;
namespace WetherApp
{
    class WeatherInfo
    {
        public float speed { get; set; }
        public float clouds { get; set; }
        public string description { get; set; }
        public float overcast_clouds { get; set; }
    }
}