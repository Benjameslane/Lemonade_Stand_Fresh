using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LemonadeStand
{
    internal class Program
    {
        static void Main(string[] args)
        {

            game game = new game();
            game.StartGame();

            // S in SOLID is displayed within the day class under GetWeatherForecastToday()   
            // Another S in Solid is displayed within the Game class under DisplayWelcome()


        }
    }
}