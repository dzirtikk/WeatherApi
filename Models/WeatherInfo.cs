using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherAPI.Models
{
    public class WeatherInfo
    {
       public WeatherMain Main { get; set; }
       
        public int id { get; set; }
       
       public string name { get; set; }

    }
}
