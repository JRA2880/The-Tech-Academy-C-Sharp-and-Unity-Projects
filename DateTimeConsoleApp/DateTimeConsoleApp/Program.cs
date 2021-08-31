using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///  Developer: John R. Adams
///  Task: DateTime Consol App Assignment
///  Requirements:
///  1.) Prints the current date and time to the console.
///  2.) Asks the user for a number.
///  3.) Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
/// </summary>
namespace DateTimeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;
            int currentHour = currentDate.Hour;
            DateTime futureDate;
            Console.WriteLine("The current Date is {0}", currentDate);
            Console.WriteLine("The current Hour is {0}:00 military time", currentHour);
            Console.WriteLine("Please enter a number to what the exact time will be: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            futureDate = currentDate.AddHours(userInput);
            Console.WriteLine("The date from {0} hours from now will be {1}.", userInput, futureDate);
            Console.Read();
        }
    }
}
