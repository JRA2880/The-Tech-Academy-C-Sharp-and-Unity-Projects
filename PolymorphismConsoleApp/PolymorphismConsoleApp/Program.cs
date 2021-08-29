using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///  Developer: John R Adams
///  Task: Polymorphism Console App Assignment
///  Requirements:
///  1.) Create an interface called IQuittable and have it define a void method called Quit().
///  2.) Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.
///  3.) Use polymorphism to create an object of type IQuittable and call the Quit() method on it. Hint: an object can be of an interface type if it implements that specific interface.
/// </summary>

namespace PolymorphismConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { firstName = "Joe", lastName = "Scrubs" };
            IQuittable IQuit = employee1;
            IQuit.Quit(employee1);
            Console.Read();
        }
    }
}
