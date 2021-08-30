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
            //Deck deck = new Deck();
            List<int> numberList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            //int sum = numberList.Sum();
            int sum = numberList.Where(x => x > 2).Sum();
            Console.WriteLine(sum);

            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //} 
            //int count = deck.Cards.Count(x => x.Face == Face.Ace);
            //Console.WriteLine(count);
            //deck.Shuffle(2);

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
