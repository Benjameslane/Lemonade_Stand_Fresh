using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Day
    {

        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>();
        }

        public Weather weather;
        public List<Customer> customers;
     
        public double SimulateDay(Player player)
            
        {
            Random random = new Random();
            double revenue;
            revenue = 0;
            Day temp = this;


            for (int i = 0; i < random.Next(10, 100); i++)
            {
                customers.Add(new Customer(player, temp));
            }

            while (customers.Count() > 0)
            {
                if (customers[0].demand < 0)
                {
                    revenue += player.recipe.price;
                  
                }
                    customers.RemoveAt(0);
            }
            return revenue;
      
        
        }
        public void GetWeatherForecastToday()                                            //Here is a good example of SRP!!!!!!!
        {
            
                Console.WriteLine($"The forecast is {weather.predicatedForecast}");
        }

    }
}
