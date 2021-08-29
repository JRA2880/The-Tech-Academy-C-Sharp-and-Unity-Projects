using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///  Developer: John R Adams
///  Task: Operators Console App Assignment
///  Requirements: 
///  1.) Overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property.
/// </summary>

namespace OperatorsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { ID = 120, firstName = "Adam", lastName = "Sturges" };
            Employee employee2 = new Employee() { ID = 43, firstName = "Maurice", lastName = "Daniels" };
            Employee employee3 = new Employee() { ID = 120, firstName = "Eve", lastName = "Hollows" };
            Employee employee4 = new Employee() { ID = 56, firstName = "Geroge", lastName = "Pinkerton" };
            CheckEmployeeIDs(employee1, employee2);
            CheckEmployeeIDs(employee1, employee3);
            Console.Read();
        } 
        public static void CheckEmployeeIDs(Employee employeeID1, Employee employeeID2)
        {
            if(employeeID1 == employeeID2)
            {
                Console.WriteLine("Employee {0} and Employee {1} have the same Employee ID.", employeeID1.lastName, employeeID2.lastName);
                Console.WriteLine("Please change one of the IDs for the employees as duplicate ID numbers are against company policy.\n");
            } 
            else
            {
                Console.WriteLine("Employee {0} and Employee {1} do not have the same Employee ID.", employeeID1.lastName, employeeID2.lastName);
                Console.WriteLine("There is no need to alter any Employee IDs.\n");
            }
        }
    }
}
