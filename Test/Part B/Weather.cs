using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermQ3
{

    class Weather
    {
        public string Month;
        public int Year;
        public int RainFall;
        public double Temperature;

        public Weather(string month, int year, int rainfall, double temperature)
        {
            this.Month = month;
            this.Year = year;
            this.RainFall = rainfall;
            this.Temperature = temperature;
        }
    }
}
