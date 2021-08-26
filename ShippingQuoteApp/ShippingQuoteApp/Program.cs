using System;

//Developer: John R Adams
//Assignment: Branching Submission Assignment
//Task: Your job is to create a console-based application for getting a shipping quote for a package.
//
//REQUIREMENTS:
//1.) First line must display "Welcome to Package Express.  Please follow the instructions below."
//2.) Prompt the user to enter the package weight.
//3.) If the package weight is greater than 50, display an error message: "Package too heavy to be shipped via Package Express. Have a good day.  //End Program.
//4.) Prompt user for the package width
//5.) Prompt user for the packge height
//6.) Prompt user for the package length
//7.) If the dimensions of the package total are greater than 50, display the error message: "Package too big to be shipped via Package Express." //End Program.
//8.) Multiply the package dimensions (height * width * length), then multiply this variable by the product weight.  Then divide the result by 100.
//9.) Print the result of the calculation to the screen as a quote.
//10.) Display  the quote to the user as the dollar amount.


namespace ShippingQuoteApp
{
    class Program
    {
        static void Main()
        {
            double packageWeight = 0.0;
            double packageWidth = 0.0;
            double packageHeight = 0.0;
            double packageLength = 0.0;
            double packageDimensions = 0.0;
            double packageQuote = 0.0;
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");
            Console.WriteLine("Please enter package weight: >> ");
            packageWeight = Convert.ToDouble(Console.ReadLine());
            if(packageWeight > 50.0)
            {
                Console.WriteLine("Package to heavy to be shipped via Package Express. Have a good day.");
                Console.Read();
                Environment.Exit(0);
            }
            Console.WriteLine("Enter package width: ");
            packageWidth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter package height: ");
            packageHeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter package length: ");
            packageLength = Convert.ToDouble(Console.ReadLine());
            packageDimensions = packageWidth + packageHeight + packageLength;
            if(packageDimensions > 50.0)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.Read();
                Environment.Exit(0);
            } 
            else
            {
                packageQuote = ((packageWidth * packageHeight * packageLength) * packageWeight)/ 100;
                
            }
            Console.WriteLine("Your estimated total for shipphing this package is: {0}", packageQuote.ToString("C"));
            Console.Read();
        }
    }
}
