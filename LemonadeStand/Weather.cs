using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Weather
    {
       

        public Random random;
        public string condition;
        public int temperature;
        private List<string> weatherConditions;
        public int weatherIndex;



        public Weather()
        {
            random = new Random();
            weatherConditions = new List<string> { "rainy", "sunny", "cloudy", "drought" };

        }
        
        
       public void PredicatedForecast()
        {
           weatherIndex = random.Next(4);
           temperature = random.Next(50, 101);
           condition = weatherConditions[weatherIndex];
        }

    }
}
