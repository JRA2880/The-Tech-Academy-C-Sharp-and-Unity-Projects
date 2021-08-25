using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Qualified = false;
            Console.WriteLine("Welcome to ACME Car Insurance!");
            Console.WriteLine("Please answer the following questions to determine if you qualify for our car insurance: >> ");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("What is your age? Please enter only a number: >> ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please enter Y for yes, and N for no: >> ");
            string duiInquiry = Console.ReadLine();
            char hasDUI = Convert.ToChar(duiInquiry);
            Console.WriteLine("How many speeding tickets do you have? Please enter only a number: >> ");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            if (age <= 15 || hasDUI == 'Y' || speedingTickets > 3)
            {
                Console.WriteLine("Are you qualified for car insurance with ACME insurance?");
                Console.WriteLine(Qualified);
                Console.WriteLine("Sorry, you don't qualify for car insurance with ACME insurance.  Please try again later.");
            }
            else 
            {
                Console.WriteLine("Are you qualified for car insurance with ACME insurance?");
                Qualified = true;
                Console.WriteLine(Qualified);
                Console.WriteLine("Excellent! You are qualified for car insurance with ACME car insurance!  One of our representatives will be in touch!");
            }    
            Console.ReadLine();
        }
    }
}
