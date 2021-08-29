using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismConsoleApp
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);

        } 
        public void Quit(Employee employee)
        {
            Console.WriteLine("Employee {0} {1} says I QUIT!!!", firstName, lastName);
        }
    }
}
