using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionConsoleApp
{
     static class FamousPerson
    {
        public static string FP_fname = "Tom";
        public static string FP_lname = "Hanks";
        public static string FP_knownFor = "Great Actor";
        public static string FP_quote = "If it wasn't hard, everyone would do it. It's the hard that makes it great.";

        public static void info()
        {
            Console.WriteLine("The info of the famous person we are following: ");
        }
    }
}
