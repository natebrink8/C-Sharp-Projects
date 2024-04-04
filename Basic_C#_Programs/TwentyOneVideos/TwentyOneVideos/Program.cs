using System;
using System.IO;
using Casino;



namespace TwentyOneVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "The Great Snookumz Hotel & Casino";

            Console.WriteLine("Welcome to the {0}! Let's start by getting your name.", casinoName);
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("How much is your gaming budget for today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only (no symbols or decimals.)");
            }

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\ochob\Logs\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
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
