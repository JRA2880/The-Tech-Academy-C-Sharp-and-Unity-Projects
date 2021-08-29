using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///  Developer: John R Adams
///  Task: Struct Console App Assignment
///  Requirements:
///  1.) Create a struct called Number and give it the property “Amount” and have it be of data type decimal.
///  2.) In the Main() method, create an object of data type Number and assign an amount to it.
///  3.) Print this amount to the console.
/// </summary>

namespace StructConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberValue number = new NumberValue();
            number.Amount = 2.71828m;
            Console.WriteLine("The number stored in this struct value is familiar to anyone who knows of the famous mathematician Leonhard Euler: {0}", number.Amount.ToString());
            Console.ReadLine();
        } 
        public struct NumberValue
        {
            public decimal Amount { get; set; }
        }
    }
}
