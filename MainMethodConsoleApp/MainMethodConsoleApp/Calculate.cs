using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodConsoleApp
{
    class Calculate
    { 
        public int Function(int input)
        {
            int result = (input + input);
            return result;
        } 
        public decimal Function(decimal input)
        {
            decimal result = Math.Abs((input * input));
            return result;
        } 
        public int Function(string input)
        {
            int userInput = Convert.ToInt32(input);
            int result = Math.Abs((userInput * userInput * userInput) / userInput);
            return result;
        }
    }
}
