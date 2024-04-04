using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOneVideos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Snookumz Hotel & Casino! Let's start by getting your name.");
            string playerName = Console.ReadLine();
            
            Console.WriteLine("How much is your gaming budget for today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21?", playerName);
            string answer = Console.ReadLine().ToLower();
            
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing. All your bases are belong to us.");
            }
            
            Console.WriteLine("Feel free to enjoy the casino buffet. See ya!");
            Console.Read();
        }
    }
}
