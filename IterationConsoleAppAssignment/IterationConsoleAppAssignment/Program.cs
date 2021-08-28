using System;
using System.Collections.Generic;

/// <summary>
///  Developer: John R. Adams
///  Task Name: Console APP Assignment Part One
///  Requirements:
///  1.) Create a console app that does/contains the following:
///  2.) A one-dimensional array of strings.
///  3.) Ask the user to input some text.
///  4.) A loop that iterates through each string of the array and adds the user's text input to the end of each string.
///  5.) Then create a loop that prints off each string in the array on a seperate line.
/// </summary>  
/// 

/// <summary> 
/// Task Name: Console App Assignment Part Two
/// Requirements: Add the following to your console app and perform these actions:
/// 1.) Create an infinite loop
/// 2.) Save your code
/// 3.) Fix the infinite loop so that it will execute properly
/// </summary> 

/// <summary>
/// Task Name: Console App Assignment Part Three
/// Requirements: Add the following to your console app and perform these actions:
/// 1.) A loop where the comparison that is used to determine whether to continue iterating the loop is a "<" opertaor.
/// 2.) Save and execute the code.
/// 3.) A loop where the comparison that is used to determine whether to continue iterating the loop is a "<=" operator.
/// 4.) save and execute the code.
/// </summary> 

///<summary>
///Task Name: Console App Assignment Part Four
///Requirements: Add the following to your console app and peform these actions:
///1.) A list of strings where each item is unique
///2.) Ask the user to input text to search for in the list.
///3.) A loop that iterates through the list and then displays the index of the list that contains matching text on the screen.
///4.) Add code to the loop that tells the user if they put in text that isn't in the list.
///5.) Add code to the loop that stops it from executing once the match has been found.
///6.) Save and execute your code.
///</summary> 

///<summary>
///Task Name: Console App Assignment Part Five
///Requirements: Add the following to your console app and perform these functions:
///1.) A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
///2.) Create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen.
///3.) Add code to the loop that tells the user if they put in text that isn't in the list.
///4.) Save and execute your code.
///</summary> 

///<summary> 
///Task Name: Console App Part Six Submission Assignment
///Requirements: Add the following to your console app and perform these actions:
///1.) Create a list of strings that has at least two identical strings in the list.
///2.) Create a foreach loop that evaluates each item in the list, and displays a message showing the string and wheter or not it has already appeared in the list.
///3.) Save and execute your code.
///</summary>



namespace IterationConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task One: Console App Part I
            string[] colorArray = { "red", "blue", "green", "yellow", "orange" };
            Console.WriteLine("Enter your favorite color: ");
            string usercolor = Console.ReadLine();
            for (int i = 0; i < colorArray.Length; i++)
            {
                Console.WriteLine(colorArray[i] + "-" + usercolor);
            }

            //Task Two: Console App Part II
            //Infinite Loop Example
            //for(; ; )
            //{
            //    Console.WriteLine("Tech Academy Game Developers UNITE!!!");
            //} 
            //
            //Fixed Infinite Loop Example
            Console.WriteLine("Enter a number higher 2 but lesser than 20: ");
            int loopLength = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < loopLength; i++) //Fixed infinite loop here
            {
                Console.WriteLine("Tech Academy Game Developers UNITE!!!");
            }

            //Task Three: Console App Part III
            //Loop where the comparison to determine to continue iterating is a "<" operator
            int[] highScores = { 25, 100, 200, 300, 1000, 2000, 5000, 100000 };
            for (int i = 0; i < highScores.Length; i++)
            {
                Console.WriteLine("Player {0} Score: " + highScores[i].ToString("#,#"), i);
            }
            //Loop where the comparison to determine to continue iterating is a "<=" operator
            for (int j = 0; j <= 4; j++)
            {
                Console.WriteLine("{0}: Evil troll attacks for +1 damage!", j);
            }
            Console.WriteLine("Evil troll did a total of five damage...");

            //Task Four: Console App Part IV
            List<string> inventory = new List<string>() { "Odin's Eye", "Merlin's Hat", "Monkey's Paw", "Excalibur" };
            Console.WriteLine("Welcome Mystical Emporium! Is there a certain item you are looking for today?");
            string item = Console.ReadLine();
            bool hasItem = false;
            while (!hasItem)
            {
                for (int i = 0; i < inventory.Count; i++)
                {
                    if (item == inventory[i])
                    {
                        Console.WriteLine("Inventory Location: {0}", i);
                        Console.WriteLine("Thank you for shopping at the Mystical Emporium!");
                        hasItem = true;
                    }
                }
                if (!(inventory.Contains(item)))
                {
                    Console.WriteLine("Sorry item is not in the inventory.");
                    Console.WriteLine("Please enter an item, and we will see if we have it in the inventory!");
                    item = Console.ReadLine();
                }
            }

            ////Task Five: Console App Part V:
            List<string> GamesInventory = new List<string>() { "Super Mario Bros.", "Luigi's Mansion", "Megaman", "Halo", "Legend of Zelda", "Metroid", "Castlevania", "Metroid" };
            Console.WriteLine("Thank you for visiting Games HQ, please enter the name of a game, and we will search our inventory for the location: ");
            string request = Console.ReadLine();
            bool hasGame = false;
            while (!hasGame)
            {
                for (int i = 0; i < GamesInventory.Count; i++)
                {
                    if (request == GamesInventory[i])
                    {
                        Console.WriteLine("Game Name: {0} | Game Location: {1}", request, i);
                        hasGame = true;
                    }
                    if (!(GamesInventory.Contains(request)))
                    {
                        Console.WriteLine("Sorry, we don't have that game in stock right now.  Please enter another game: ");
                        Console.WriteLine("Please enter another game, and we will see if it is in stock!");
                        request = Console.ReadLine();
                    }
                }
            }

            //Task Six: Console App Part VI
            List<string> groceryList = new List<string>() { "apples", "oranges", "bananas", "bread", "celery", "peanut butter", "jam", "apples","peanut butter","peaches","chips"};
            List<string> groceryDuplicates = new List<string>();
            foreach (string listitem in groceryList)
            {
                if (groceryDuplicates.Contains(listitem))
                {
                    Console.WriteLine(listitem + " has appeared before.");
                }
                groceryDuplicates.Add(listitem);
            }
            Console.Read();
        }
    }
}
