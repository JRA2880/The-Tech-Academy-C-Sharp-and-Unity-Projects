using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///  Developer: John R. Adams
///  Task: Lambda Console App Assignment
///  Requirements:
///  
/// </summary>

namespace LambdaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> newEmployees = new List<Employee>();
            newEmployees.Add(new Employee() { FirstName = "Joe", LastName = "Chill", EmployeeID = 1 });
            newEmployees.Add(new Employee() { FirstName = "Wendy", LastName = "Green", EmployeeID = 2 });
            newEmployees.Add(new Employee() { FirstName = "Alice", LastName = "Winter", EmployeeID = 3 });
            newEmployees.Add(new Employee() { FirstName = "George", LastName = "Kastanza", EmployeeID = 4 });
            newEmployees.Add(new Employee() { FirstName = "Ernesto", LastName = "Curry", EmployeeID = 5 });
            newEmployees.Add(new Employee() { FirstName = "Gilbert", LastName = "Mason", EmployeeID = 6 });
            newEmployees.Add(new Employee() { FirstName = "Ricky", LastName = "Ricardo", EmployeeID = 7 });
            newEmployees.Add(new Employee() { FirstName = "Joe", LastName = "Richards", EmployeeID = 11 });
            newEmployees.Add(new Employee() { FirstName = "Blake", LastName = "Stokes", EmployeeID = 8 });
            newEmployees.Add(new Employee() { FirstName = "Lee", LastName = "Spencer", EmployeeID = 9 });
            newEmployees.Add(new Employee() { FirstName = "Bok", LastName = "Dotson", EmployeeID = 10 });
            newEmployees.Add(new Employee() { FirstName = "John", LastName = "Harker", EmployeeID = 12 });

            List<Employee> newList = new List<Employee>();
            foreach (Employee employee in newEmployees)
            {
                if (employee.FirstName == "Joe")
                {
                    newList.Add(employee);
                }

            }
            foreach (Employee employee in newList)
            {
                Console.WriteLine("This is from the new List: {0}.", employee.FirstName);
            }

            List<Employee> onlytheJoes2 = newEmployees.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee employee in onlytheJoes2)
            {
                {
                    Console.WriteLine("This is from the list only with the Joes: {0}.", employee.FirstName);
                }
            }

            List<Employee> EmployeeIDGreaterThan5 = newEmployees.Where(x => x.EmployeeID > 5).ToList();

            foreach (Employee employee in EmployeeIDGreaterThan5)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.EmployeeID);
            }
            Console.Read();
        }
    }
}
