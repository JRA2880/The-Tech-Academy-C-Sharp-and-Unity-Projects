using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Developer: John R. Adams
/// Task: Try-Catch Console App Assignment
/// Requirements:
/// Perform  these actions and create a console app that includes the following:
/// 1.) Create a list of integers.  Ask the user for a number to divide each number in the list by.  
///     Write a loop that takes each integer in the list, divides it by the number the user entered, and displays
///     the result to the screen.
/// 2.) Run the code, entering non-zero numbers as the user. Look at the displayed results.
/// 3.) Run the code again, entering zero as the number to divide by.  Note the error messages you get.
/// 4.) Run the code once again, entering in a string as the number to divide by. Note any error messages that you get.
/// 5.) Now put the loop in a try/catch block.  
/// 6.) Below and outside  of the try/catch block, make the program print a message to the display to let you know has emerged from the
///     try/catch block and continued on with the program execution.
/// 7.) In the catch block, display the error message to the screen.
/// 8.) Try various combinations of user input: valid numbers, zero, and a string. 
/// 9.) Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.
/// </summary>

namespace TryCatchConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numberList = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
                Console.WriteLine("Enter a number to divide into the number list to see what the results are: ");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numberList.Count; i++)
                {
                    int result = numberList[i] / userNumber;
                    Console.WriteLine("{0} divided by {1} equals {2}", numberList[i], userNumber, result);
                }
            } 
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide zero.");
            } 
            catch(FormatException ex)
            {
                Console.WriteLine("Please enter a whole number.");
            } 
            finally
            {
                Console.WriteLine("Thanks for using this console application!");
            }
            Console.Read();
        }
    }
}
