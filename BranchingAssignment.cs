using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BranchingAssignment
{
    class Program
    {
        static void Main()
        {
            //Step One: Display the welcome message.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //Step Two: Ask for package weight.
            Console.WriteLine("Please enter the package weight:");
            double PackageWeight = Convert.ToDouble(Console.ReadLine());
            //Step Three: If weight is more than 50, exit the program.
            if (PackageWeight > 50)
            {
                Console.WriteLine("Sorry, the package is too heavy to be shipped with Package Express. Have a great day!");
            }
            else
            {
                Console.WriteLine("Please enter the package width");
            }

            //Step Four: Ask for package width.
           
            double PackageWidth = Convert.ToDouble(Console.ReadLine());

            //Step Five: Ask for package height.
            Console.WriteLine("Please enter the package height:");
            double PackageHeight = Convert.ToDouble(Console.ReadLine());

            //Step Six: Ask for package length.
            Console.WriteLine("Please enter the package length:");
            double PackageLength = Convert.ToDouble(Console.ReadLine());

            //If width, height and length exceed 50, end the program.

            if (PackageWidth + PackageHeight + PackageLength > 50)
            {
                Console.WriteLine("Sorry, the package is too big to be shipped with Package Express. Have a great day!");
            }
            else
            {
                double quote = (PackageWidth * PackageHeight * PackageLength * PackageWeight) / 100;
            }
            //The total shipping amount will be displayed.
            Console.WriteLine("The estimated total cost to ship this package is: $" + quote.ToString("F2"));

            //Thanking the customer for shipping their package with us.
            Console.WriteLine("Thank you for using Package Express!! Have a Fantastic Day!!");

            Console.ReadLine();

        }
    }
}
