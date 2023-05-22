using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Weather
    {
       

        Random random;
        public string condition;
        public int temperature;
        private List<string> weatherConditions;
        public string predicatedForecast;
        public int weatherIndex;

        public Weather()
        {
            random = new Random();
            weatherIndex = random.Next(4);
            List<string> weatherConditions = new List<string>  {"rainy", "sunny", "cloudy", "drought"};
            temperature = random.Next(50, 101);
            predicatedForecast = weatherConditions[weatherIndex];
           
        }
        
       
    }
}
