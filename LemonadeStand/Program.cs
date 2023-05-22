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
            // The Liskov substitution principle is shown within the LemonadePitcher child class.
            // The Liskov substitution principle applies to the rest if Items child classes
            // there are no examples of Interface Segregation Principles due to there being no methods within the Parent classes
        }
    }
}