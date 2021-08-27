using System;
using System.Collections.Generic;

/// <summary>
/// Developer: John R. Adams
/// Task: Arrays Submission Assignment
/// Requirements:
/// 1.) Create a console app that does/contains the following:
/// 2.) Create a one-dimensional Array of Strings.  Ask the user to select an idex of the Array and then display the string at that index on the screen.
/// 3.) Create a one-dimensional Array of Integers. Ask the user to select an idex of the Array and then display the integer at that index on the screen.
/// 4.) Add in a message that displays when the user selects an idex that doesn't exist.
/// 5.) Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.
/// </summary>

namespace ArrayAndListAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   
            //String Array populated with famous game characters
            string[] characterArray = { "Mario", "Zelda", "Pac-Man", "Mega-Man", "Luigi"};
            Console.WriteLine("Enter a number see the game character at that index");
            int characterIndex = Convert.ToInt32(Console.ReadLine());
            if(characterIndex >= characterArray.Length)
            {
                Console.WriteLine("Sorry, there is not a game character name at that index, please try again: ");
                Console.WriteLine("Enter a number see the game character at that index");
                characterIndex = Convert.ToInt32(Console.ReadLine());
            }
            if(characterIndex < characterArray.Length)
            {
                Console.WriteLine("The character at that index {0} is {1}",characterIndex, characterArray[characterIndex]);
            } 
            else
            {
                Console.WriteLine("Enter a number see the game character at that index");
                characterIndex = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            //Integer Array
            int[] numArray = { 10, 15, 30, 760, 1000};
            Console.WriteLine("Enter a number to see the number at that index: ");
            int numIndex = Convert.ToInt32(Console.ReadLine());
            if(numIndex >= numArray.Length)
            {
                Console.WriteLine("Sorry, there is not a number at that index, please try again: ");
                Console.WriteLine("Enter a number to see the number at that index: ");
                numIndex = Convert.ToInt32(Console.ReadLine());
            }
            if( numIndex < numArray.Length)
            {
                Console.WriteLine("The number at index {0} is {1}", numIndex, numArray[numIndex]);
            }
            else
            {
                Console.WriteLine("Enter a number to see the number at that index: ");
                numIndex = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            //List populated with the names of famous games
            List<string> gameList = new List<string>{"Halo","Castlevania","Punch-Out!!!","Spyhunter","Metroid"};
            Console.WriteLine("Enter a number to see the name of the game at that index: ");
            int gameIndex = Convert.ToInt32(Console.ReadLine());
            if(gameIndex >= gameList.Count)
            {
                Console.WriteLine("Sorry, there is not a number at that index, please try again: ");
                Console.WriteLine("Enter a number to see the name of the game at that index: ");
                gameIndex = Convert.ToInt32(Console.ReadLine());
            } 
            if(gameIndex < gameList.Count)
            {
                Console.WriteLine("The name of the game at index {0} is {1}", gameIndex, gameList[gameIndex]);
            } 
            else
            {
                Console.WriteLine("Enter a number to see the name of the game at that index: ");
                gameIndex = Convert.ToInt32(Console.ReadLine());
            }
            Console.Read();
        }
    }
}
