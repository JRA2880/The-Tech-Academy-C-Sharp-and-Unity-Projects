using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/// <summary>
///  Developer: John R Adams
///  Task: Input Challenge
///  Requirements:
///  1.) Asks the user for a number.
///  2.) Logs that number to a text file.
///  3.) Prints the text file back to the user.
/// </summary>

namespace NumberLogConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number into the Number Log to record it to file: ");
            int input = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter recordNumber = new StreamWriter(@"D:\GitHub\The-Tech-Academy-C-Sharp-and-Unity-Projects\NumberLogConsoleApp\Logs\log.txt", true))
            {
                recordNumber.WriteLine("Number Log: {0}", input);
            }
            StreamReader readLog = new StreamReader(@"D:\GitHub\The-Tech-Academy-C-Sharp-and-Unity-Projects\NumberLogConsoleApp\Logs\log.txt");
            string logEntry = readLog.ReadLine();

            while(logEntry != null)
            {
                Console.WriteLine(logEntry);
                logEntry = readLog.ReadLine();
            }
            readLog.Close();
            Console.Read();
        }
    }
}
