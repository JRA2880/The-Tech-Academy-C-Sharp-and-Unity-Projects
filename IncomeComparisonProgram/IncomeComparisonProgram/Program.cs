using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonyous Income Comparison Program");
            Console.WriteLine("-------------------------------------------------");
            Console.Write("Enter Person 1's hourly rate: ");
            double Person1HourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Person 1's hours worked per week: ");
            double Person1HoursPerWeek = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");
            Console.Write("Enter Person 2's hourly rate: ");
            double Person2HourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Person 2's hours worked per week: ");
            double Person2HoursPerWeek = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");
            double Person1AnnualSalary = Person1HourlyRate * Person1HoursPerWeek * 52.0;
            Console.WriteLine("Annual salary of Person 1: {0}", Person1AnnualSalary.ToString("C"));
            Console.WriteLine("-------------------------------------------------");
            double Person2AnnualSalary = Person2HourlyRate * Person2HoursPerWeek * 52.0;
            Console.WriteLine("Annual salary of Person 2: {0}", Person2AnnualSalary.ToString("C"));
            Console.WriteLine("-------------------------------------------------");
            bool isGreater = Person1AnnualSalary >= Person2AnnualSalary;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.Write(isGreater);
            Console.Read();

        }
    }
}
