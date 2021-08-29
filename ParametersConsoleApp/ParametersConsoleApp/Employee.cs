using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersConsoleApp
{
    public class Employee<T>
    { 
        public int EmployeeID { get; set; }
        public List<T> EmployeeThings { get; set; }
    }
}
