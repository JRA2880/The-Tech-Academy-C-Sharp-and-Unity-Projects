using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodConsoleAppAssignment
{
    class Calculate
    {
        public double Square(double number)
        {
            double square = Math.Pow(number, 2.0);
            return square;
            
        } 
        public double Cube(double number)
        {
            double cube = Math.Pow(number, 3.0);
            return cube;
        } 
        public double SquareRoot(double number)
        {
            double squareRoot = Math.Sqrt(number);
            return squareRoot;
        }
    }
}
