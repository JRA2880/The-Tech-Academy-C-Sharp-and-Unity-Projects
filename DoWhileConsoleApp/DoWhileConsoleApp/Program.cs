using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Guess an animal?:");
            string animal = Console.ReadLine();
            bool isGuessed = animal == "tiger";

            do
            {
                switch (animal)
                {
                    case "walrus":
                        Console.WriteLine("You guessed walrus. Try again.");
                        Console.WriteLine("Guess an animal?");
                        animal = Console.ReadLine();
                        break;
                    case "dolphin":
                        Console.WriteLine("You guessed dolphin. Try again.");
                        Console.WriteLine("Guess an animal?");
                        animal = Console.ReadLine();
                        break;
                    case "penguin":
                        Console.WriteLine("You guessed penguin. Try again.");
                        Console.WriteLine("Guess an animal?");
                        animal = Console.ReadLine();
                        break;
                    case "tiger":
                        Console.WriteLine("You guessed tiger. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong!");
                        Console.WriteLine("Guess an animal?");
                        animal = Console.ReadLine();
                        break;
                }
            }
            while (!isGuessed);
            Console.Read();
        }
    }
}
