using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Developer: John R Adams
/// Task: Optional Parameters Method Submission Assignment
/// Requirements:
/// Peform these actions and create a console app that includes the following:
/// 1.) Create a class. In that class, create a method that takes two integers as parameters. Make one of them optional. 
///     Have the method do a math operation and return an integer result.
/// 2.) In the Main() method of the console app, instantiate the class.
/// 3.) Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.
/// 4.) Call the method in the class, passing in the one or two numbers entered.
/// 5.) Try various combinations of numbers on the code, including having no second number.
/// </summary>

namespace OptionalParametersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calculator = new Calculate();
            Console.WriteLine("Enter a number to have the result calculated: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number.  This number is opitional, if you don't want to enter another number, press 1.");
            Console.WriteLine("Please enter a number, or press 1 to skip: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result1 = calculator.Function(num1);
            int result2 = calculator.Function(num1, num2);
            Console.WriteLine("Result with only one number: {0}.", result1);
            Console.WriteLine("Result with two numbers: {0}.", result2);
            Console.ReadLine();
        }
    }
}
