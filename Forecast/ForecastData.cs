using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppUsingApi
{
    internal class ForecastData
    {
        public string maxTemp {  get; set; }            //maxtemp_f
        public string minTemp {  get; set; }            //mintemp_f
        public string willItRain { get; set; }          //daily_will_it_rain
        public string chanceOfRain { get; set; }        //daily_chance_of_rain
        public string overallCondition { get; set; }    //text
        public string overallConditionUrl { get; set; } //icon
    }
}
