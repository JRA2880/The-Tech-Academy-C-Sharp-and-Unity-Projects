using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///  Developer: John Adams
///  Task: Calling Methods Console App Submission Assignment
///  Requirements:
///  1.) Peform these actions and create a console app that includes the following:
///  2.) Create a class. In that class, create three methods, each of which will take one integer parameter in and 
///      return the integer.  The methods should do some math operation on the received parameter. 
///      Put this class in a seperate .cs file in the application.
///  3.) In the Main() program, ask the user what number they want to do math operations on.
///  4.) Call each method in turn, passing in the user input.  Display each returned integer to the screen.
/// </summary>

namespace MethodConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to determine the square, cube, and square root of that number: ");
            double userNumber = Convert.ToDouble(Console.ReadLine());
            Calculate number = new Calculate();
            double square = number.Square(userNumber);
            double cube = number.Cube(userNumber);
            double sqRoot = number.SquareRoot(userNumber);

            Console.WriteLine("The number {0} squared equals: {1}", userNumber, square);
            Console.WriteLine("The number {0} cubed equals: {1}", userNumber, cube);
            Console.WriteLine("The number {0} square root equals: {1}", userNumber, sqRoot);
            Console.Read();

            



        }
    }
}
