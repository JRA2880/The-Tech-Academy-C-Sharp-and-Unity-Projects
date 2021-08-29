using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionConsoleApp
{
    class Calculate
    { 
        public void Function(int input)
        {
            int result = input / 2;
            Console.WriteLine("The number you entered divided by 2 equals: " + result);
        }  
        public int Function(int input1, int input2, out int total)
        {
            total = input1 + input2;
            return total;
        } 
        public string Function(string input)
        {
            string start = "Got ";
            string end = start + input + "?";
            return end;
        }

    }
}
