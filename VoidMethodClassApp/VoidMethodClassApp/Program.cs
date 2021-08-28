using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Developer: John R Adams
/// Task: Method Class Submission Assignment
/// Requirements: 
/// 1.) Create a class. In that class, create a void method that takes two integers as parameters. 
///     Have the method do a math operation on the first integer and display the second integer to the screen.
/// 2.) In the Main() method of the console app, instantiate the class.
/// 3.) Call the method in the class, passing in two numbers.
/// 4.) Call the method in the class, specifying the parameters by name.
/// </summary>

namespace VoidMethodClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Function function = new Function();
            function.FunctionHelper(num1: 5, num2: 10);
            Console.Read();
        }
    }
}
