using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///  Developer: John R Adams
///  Task: Parameters Submission Assignment
///  Requirements:
///  1.) Make an Employee Class that takes a generic type parameter.
///  2.) Add a property to the Employee class called “things” and have its data type be a generic list matching the generic type of the class.
///  3.) Instantiate an Employee object with type “string” as its generic parameter. Assign a list of strings as the property value of Things.
///  4.) Instantiate an Employee object with type “int” as its generic parameter. Assign a list of integers as the property value of Things.
///  Create a loop that prints all of the Things to the Console.
/// </summary>

namespace ParametersConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;
            Employee<string> employee1 = new Employee<string>();
            employee1.EmployeeThings = new List<string>() { "Interdimensional tracker", "Plasma shotgun", "Package for deliery", "Warp trap" };
            Employee<int> employee2 = new Employee<int>();
            employee2.EmployeeThings = new List<int>() { 1234, 5680, 340989, 543290 };

            Console.WriteLine("These are the items that a new Inter-Dimensional Mailman is issued for service and must carry at all times: \n");
            foreach(string thing in employee1.EmployeeThings)
            {
                index = employee1.EmployeeThings.FindIndex(a => a.Contains(thing));
                Console.WriteLine(employee1.EmployeeThings[index]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Inter-Dimensional Mailmen work in pairs, the second Mailman must guard the coordinates to the dimensions for package delivery: ");
            for(int i = 0; i < employee2.EmployeeThings.Count; i++)
            {
                Console.WriteLine(employee2.EmployeeThings[i]);
            }
            Console.WriteLine("The first package is to be delivered to dimension {0}.  Please be careful here, there are many inter-dimensional shamblers that can follow across dimensions.", employee2.EmployeeThings[0]);
            Console.WriteLine("The second package is to be delivered to dimension {0}, the dimension of madness.  Keep your wits about you.  No one said that this was a sane job.", employee2.EmployeeThings[1]);
            Console.WriteLine("The third package is to be delivered to dimension {0}. Please be aware of the one who sleeps below the surface.  If it awakens all is lost....", employee2.EmployeeThings[2]);
            Console.WriteLine("The third package is to be delivered to dimension {0}. Whatever you do, don't look into it's eyes....if you do, you are not coming back!", employee2.EmployeeThings[3]);
            Console.WriteLine("Thank you for joining the Inter-Dimensional Courier Service.  Without your service and dedication, all manner of beings and beastery would not get their mail.");
            Console.WriteLine("Please make sure not bring any unwanted hitchhikers on your return to Central.  You don't don't want to be that pair!");
            Console.Read();
        }
    }
}
