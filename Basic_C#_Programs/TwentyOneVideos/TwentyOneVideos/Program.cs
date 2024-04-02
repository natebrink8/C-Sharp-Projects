using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            TwentyOneGame twentyone = new TwentyOneGame();
            twentyone.Players = new List<string>() { "Jesse", "Nate", "Josh" };
            twentyone.ListPlayers();


            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);



            Console.ReadLine();
        }
    }
}
