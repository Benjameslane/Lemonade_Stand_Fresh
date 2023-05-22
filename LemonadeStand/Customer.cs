using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Customer
    {

        public double demand;
        Random random = new Random();
        
        public Customer(Player player, Day day)
        {
            demand = player.recipe.price - day.weather.weatherIndex + random.Next(-2, 2);
            
        }
        
    }
}
