using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
        

            Console.WriteLine("Welcome to the Grand Hotel and Casino.  Let's start by telling me your name.");
            string playerName = Console.ReadLine();

            Console.WriteLine("And how much did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}.  Would you like to join a game of 21 right now?", playerName);
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
                Console.WriteLine("Thank you for playing!");

            }
            Console.WriteLine("Feel free to look around the casino.  Bye for now.");
            Console.ReadLine();

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            //game.ListPlayers();
            //Console.ReadLine();

            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            //game += player;
            //game -= player;

            //Card card = new Card();
            //card.Suit = Suit.Clubs;



            //Card card1 = new Card();
            //Card card2 = card1;
            //card1.Face = Face.Eight;
            //card2.Face = Face.King;

            //Console.WriteLine(card1.Face);

            //Deck deck = new Deck();

            //int count = deck.Cards.Count(x => x.Face == Face.Ace);
           //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();


           // foreach(Card card in newList)
           // {
           //     Console.WriteLine(card.Face);
           // }
            

            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}

            //Console.WriteLine(deck.Cards.Count);
           // Console.ReadLine();
        }

    }
}
