using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class game



    {

        public List<Player> players;
        private Player player;
        private List<Day> days;
        private int currentDay;
        Day day = new Day();



        public game()
        {
            player = new Player();
            days = new List<Day>();
            currentDay = 0;

            for (int i = 0; i < 7; i++)
            {
                days.Add(new Day());
            }

        }

        public void StartGame()
            
        {
            double runningTotal = player.wallet.Money;

            double dailyTotal;
            
           

            DisplayWelcome();
            while (days.Count > 0)
            {
                dailyTotal = player.wallet.Money;
                StartDay();

                day.GetWeatherForecastToday();
                //GetWeatherForecastWeek();
                BuyItems();

                player.recipe.DisplayRecipe();
                player.wallet.AcceptMoney(days[0].SimulateDay(player));
                Console.WriteLine($"Running Total: {player.wallet.Money - runningTotal}");
                Console.WriteLine($"Daily Total: {player.wallet.Money - dailyTotal}");
                days.RemoveAt(0);
            }
        }
        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Lemonade Stand! \nYou have seven days to make as much money as you can \nThe weather, along with your pricing, can affect your success. \nCan you make the big bucks?");

        }
        public void StartDay()
        {
            Console.WriteLine("Begin Day");
            //display here the players current inventory.

        }
         public void BuyItems()
        {
            player.inventory.AddCupsToInventory(UserInterface.GetNumberOfItems("cup"));
            player.inventory.AddLemonsToInventory(UserInterface.GetNumberOfItems("lemon"));
            player.inventory.AddIceCubesToInventory(UserInterface.GetNumberOfItems("ice cube"));
            player.inventory.AddSugarCubesToInventory(UserInterface.GetNumberOfItems("sugar cube"));
                

        }
        public void ChangeRecipe()
        {
            //Recipe.DisplayRecipe();
        }

        public void GetWeatherForecastWeek()
        {
            for (int i = 0; i < days.Count; i++)
                days[i].GetWeatherForecastToday();
                
        }
        
    }
   

}
