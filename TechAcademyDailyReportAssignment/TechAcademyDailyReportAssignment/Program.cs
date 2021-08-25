using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAcademyDailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            int currentPageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer: \"true\" or \"false\"");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you'd like to provide? Please give specifics. ");
            string positiveExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int studyHours = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.  Have a great day!\n");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine("Daily Report Results");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine("Name: {0}\n", yourName);
            Console.WriteLine("Current Course: {0}\n", currentCourse);
            Console.WriteLine("Current Page Nubmer: {0}\n", currentPageNumber);
            Console.WriteLine("Need Help: {0}\n", needHelp);
            Console.WriteLine("Positive Experience: {0}\n", positiveExperience);
            Console.WriteLine("Other Feedback: {0}\n", otherFeedback);
            Console.WriteLine("Today's Study Hours: {0}\n", studyHours);
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.Read();
        }
    }
}
