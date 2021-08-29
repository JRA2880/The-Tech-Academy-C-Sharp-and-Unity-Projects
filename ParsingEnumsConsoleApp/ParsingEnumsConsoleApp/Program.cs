using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///  Developer: John R Adams
///  Task: Parsing Enums Sumbission Console App Assignment
///  Requirements:
///  1.) Create an enum for the days of the week.
///  2.) Prompt the user to enter the current day of the week.
///  3.) Assign the value to a variable of that enum data type you just created.
///  4.) Wrap the above statement in a try/catch block and have it print “Please enter an actual day of the week.” to the console if an error occurs.
/// </summary>
namespace ParsingEnumsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        { 

            try
            {
                Console.WriteLine("Please enter the current day of the week: ");
                string input = Console.ReadLine();
                DaysofTheWeek dayEntered = (DaysofTheWeek)Enum.Parse(typeof(DaysofTheWeek), input, true);
                bool isToday = dayEntered == DaysofTheWeek.Sunday;
                if(isToday)
                {
                    Console.WriteLine("Yes, today is Sunday");
                } 
                else
                {
                    Console.WriteLine("Sorry, that is not today");
                }
            } 
            catch(Exception ex)
            {
                Console.WriteLine("The input that you entered was not recognized.");
                Console.WriteLine("Please enter an actual day of the week.");
                Console.WriteLine("Please enter a day of the week: Monday, Tuesday, Wednesday, Thursday, Friday.");
            } 
            finally
            {
                Console.WriteLine("Thank you for using this Console App!");
            }
            Console.Read();
        } 
        public enum DaysofTheWeek
        {
            Monday=1,
            Tuesday=2,
            Wednesday=3,
            Thursday=4,
            Friday=5,
            Saturday=6,
            Sunday=7
        }
    }
}
