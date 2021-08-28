using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///  Developer: John R. Adams
///  Task: Main Method Console Application Assignment
///  Requirements:
///  Perform these actions and create a console app that includes the following:
///  1.) Create a class. In that class, create a method that will take in an integer.
///      Create a math operation for this integer(addidion,subtraction,etc.) then return the answer as an integer.
///  2.) Add a second method to the class with the same name that will take in a decimal, 
///      create different math operation for it, then return the answer as an integer.
///  3.) In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the result to the screen.
///  4.) Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation on it, 
///      then return the answer as an integer.
///  5.) In the Main() method of the console app, instantiate the class and call the third method, passing in a string  that equates to an integer.  Display the result to the screen.
/// </summary>

namespace MainMethodConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calculator = new Calculate();
            int result1 = calculator.Function(3);
            decimal result2 = calculator.Function(6.72m);
            int result3 = calculator.Function("9");
            Console.WriteLine("Result 1: {0}", result1);
            Console.WriteLine("Result 2: {0}", result2);
            Console.WriteLine("Result 3: {0}", result3);
            Console.Read();
        }
    }
}
