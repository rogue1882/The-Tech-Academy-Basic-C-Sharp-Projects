using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game game = new Game();
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            //game.ListPlayers();
            //game.Play();
            //Console.ReadLine();
            //Game game = new Game();
            //game.Dealer = "Jesse";
            //game.Name = "Twenty One";

            //Card card = new Card() { Face = "King", Suit = "Spades" };
            Deck deck = new Deck();
            //int timesShuffled = 0;
            //deck = Shuffle(deck);
            //deck = Shuffle(deck: deck, times: 3);
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            //Console.WriteLine(" Times shuffled: {0}", t);
            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            Console.ReadLine();
        }

        

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for(int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}





    }
}
