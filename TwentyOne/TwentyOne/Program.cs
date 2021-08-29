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
            Card card1 = new Card();
            Card card2 = card1;
            card1.Face = Face.Eight;
            card1.Suit = Suit.Hearts;
            Console.WriteLine(card2.Face.ToString() + " of " + card2.Suit.ToString());
            //Deck deck = new Deck();
            //deck.Shuffle(1);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("This line of code got it.");
            Console.ReadLine();
        }    
    }
}
