using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    public class Dealer
    {
        private List<Card> _hand = new List<Card>();
        public List <Card> Hand { get { return _hand; } set { _hand = value; } }
        public string Name { get; set; }
        public Deck Deck { get; set; } 
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"D:\GitHub\The-Tech-Academy-C-Sharp-and-Unity-Projects\TwentyOne\Logs\log.txt", true))
            {
                file.WriteLine(card);
            }
                Deck.Cards.RemoveAt(0);
        }

    }
}
