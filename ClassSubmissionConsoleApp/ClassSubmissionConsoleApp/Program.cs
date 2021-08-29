using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///  Developer: John R Adams
///  Task: Class Submission Assignment
///  Requirements:
///  1.) Create a class. In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2.
///  2.) In the Main() method, instantiate that class.
///  3.) Have the user enter a number. Call the method on that number. Display the output to the screen. It should be the entered number, divided by two.
///  4.) Create a method with output parameters.
///  5.) Overload a method.
///  6.) Declare a class to be static.
/// </summary>

namespace ClassSubmissionConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calculator = new Calculate();
            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            calculator.Function(num1);
            Console.WriteLine("Enter a number to add to the total: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number to add to the total: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int total = calculator.Function(num2, num3, out total);
            Console.WriteLine("The total of the numbers {0} and {1} are {2}", num2, num3, total);
            Console.WriteLine("Enter a word, any word: ");
            string userInput = Console.ReadLine();
            string catchPhrase = calculator.Function(userInput);
            Console.WriteLine(catchPhrase);
            FamousPerson.info();
            Console.WriteLine("Famous Person First Name: {0}", FamousPerson.FP_fname);
            Console.WriteLine("Famous Person Last Name: {0}", FamousPerson.FP_lname);
            Console.WriteLine("Famous Person is known for being a: {0}", FamousPerson.FP_knownFor);
            Console.WriteLine("Famous Person famous quote: {0}", FamousPerson.FP_quote);
            Console.Read();
        }
    }
}
