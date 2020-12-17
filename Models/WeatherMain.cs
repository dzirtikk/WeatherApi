using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;

namespace WeatherAPI.Models
{
    public class WeatherMain
    {
        public decimal temp { get; set; }

        public decimal feels_like { get; set; }
        public decimal temp_min { get; set; }
        public decimal temp_max { get; set; }
        public int humidity { get; set; }


    }
}
