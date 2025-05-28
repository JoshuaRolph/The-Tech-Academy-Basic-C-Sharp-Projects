using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //int day = 4;

            //switch(day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday.");
            //        break;

            //    case 2:
            //        Console.WriteLine("Tuesday.");
            //        break;

            //    case 3:
            //        Console.WriteLine("Wednesday.");
            //        break;

            //    case 4:
            //        Console.WriteLine("Thursday.");
            //        break;

            //    case 5:
            //        Console.WriteLine("Friday.");
            //        break;

            //    case 6:
            //        Console.WriteLine("Saturday.");
            //        break;

            //    case 7:
            //        Console.WriteLine("Sunday.");
            //        break;
            //}

            //Console.WriteLine("Guess a number?");
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool isGuessed = number == 12;
            //do
            //{
            //    switch (number)
            //    {
            //        case 62:
            //            Console.WriteLine("You guessed 62. Try again.");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 29:
            //            Console.WriteLine("You guessed 29. Try again.");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 55:
            //            Console.WriteLine("You guessed 55. Try again.");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 12:
            //            Console.WriteLine("You guessed the number 12. That is correct!");
            //            isGuessed = true;
            //            break;
            //        default:
            //            Console.WriteLine("You are wrong.");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            // }

            //    while (!isGuessed) ;

            //int count = 0;

            //do
            //{
            //    Console.WriteLine("Inside loop.");
            //    count++;
            //}
            //while (count < 5);

            //int counting = 0;
            //while (counting < 3)
            //{
            //    Console.WriteLine("Counting.");
            //    counting++;
            //}

            //int counter = 0;
            //while (counter < 10)
            //{
            //    Console.WriteLine("Counter");
            //    counter++;
            //}

            //string name = "Joshua";
            //string quote = "The man said, \"Hello\", Jesse. \n Hello on a new line. \n  \t Hello on a tab.";
            //Console.WriteLine(quote);
            //string fileName = @"C:\Users\jrolp";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //Console.WriteLine(length);

            //name = name.ToUpper();
            //Console.WriteLine(name);

            //Console.WriteLine(trueOrFalse);

            //string name = "Joshua";
            //name = "Josh";

            //Console.WriteLine(name);

            //StringBuilder sb = new StringBuilder();
            //sb.Append("My name is Joshua");
            //Console.WriteLine(sb);

            //Concatenate.
            //string firstName = "Joshua";
            //string lastName = "Rolph";
            //string fullName = firstName + " " + lastName;
            //Console.WriteLine(fullName);

            ////Lower Case.
            //string name = "Joshua";
            //name = name.ToLower();
            //Console.WriteLine(name);

            ////Upper Case.
            //string name = "Joshua";
            //name = name.ToUpper();
            //Console.WriteLine(name);

            ////My attempt at a String Builder.
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Hello, \n My name is Joshua Rolph. \n I am new to programming. \n this is basic learning in regards to doing string builder \n with new lines each time I type something.");
            //Console.WriteLine(sb);

            //Basic Addition//

            //int num1 = 2;
            //int num2 = 2;

            //int result = (2 + 2);
            //Console.WriteLine(result);

            //Finding out the wage//

            //int hours = 40;
            //double rate = 29.14;
            //double wage = hours * rate;
            //Console.WriteLine($"{rate} rate and {hours} hours are equal to {wage}.");
            //int minutes = 60;
            //int total = 40 / 60;

            //Console.WriteLine($"{hours} hours divided by {minutes} minutes are equal to {total}.");
            //int seconds = minutes / 60;
            //Console.WriteLine($"{minutes} minutes is equal to {seconds} seconds.");

            //More Basic Addition//

            //int num1 = 10;
            //num1 = num1 + 1;
            //Console.WriteLine(num1);

            //Converting Voltage and Current into Power//

            //Console.WriteLine("Enter Voltage (in volts): ");
            //double voltage = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter Current (in amperes): ");
            //double current = Convert.ToDouble(Console.ReadLine());

            //double power = voltage * current;
            //Console.WriteLine($"The Power is {power} watts.");

            //Finding out the Area of a Triangle//

            //Console.Write("Write the length of side 1: ");
            //double side1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Write the length of side 2: ");
            //double side2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Write the length of side 3: ");
            //double side3 = Convert.ToDouble(Console.ReadLine());

            //double semiperimeter = (side1 + side2 + side3) / 2;
            //double Area = Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
            //Console.Write("Area of a Triangle = " + Area);

            // Code for your Age converted into Days //

            //Console.WriteLine("Enter your birth year: ");
            //int birthYear = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your birth month (1-12): ");
            //int birthMonth = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your birth day (1-31): ");
            //int birthDay = int.Parse(Console.ReadLine());

            //DateTime birthDate = new DateTime(birthYear, birthMonth, birthDay);
            //DateTime today = DateTime.Now;

            //TimeSpan ageSpan = today - birthDate;
            //int ageInDays = (int)ageSpan.TotalDays;

            //Console.WriteLine($"Your age in days is {ageInDays} days.");

            // Returning the First Element in an Array//

            //int[] array = { 1, 2, 3, 4, 5 };
            //int firstElement = array[0];
            //Console.WriteLine(firstElement);

            //Converting Hours into Seconds //

            //Console.WriteLine("Please enter hours:");
            //int hours = Convert.ToInt32(Console.ReadLine());
            //int seconds = hours * 60 * 60;
            //Console.WriteLine(seconds + " Seconds.");

            // Finding the third side of a triangle //

            //int side1 = 10;
            //int side2 = 8;
            //int result = (side1 + side2 - 1);
            //Console.WriteLine(result);

            //int num1 = 4;
            //int num2 = 4;

            //Console.WriteLine(num1 >= num2);

            //Console.WriteLine("What is your name?");

            //string name = Console.ReadLine();

            //Console.WriteLine("Hello, " + name + "!");

            //Console.WriteLine("This is to test out the tab and new line string. \t this is the tab. \n is the new line.");
            //string doubleQuote = "The use of double quotes\" \"is necessary";

            //Console.WriteLine("Academy of Learning Career College. \n Student Daily Report.");
            
            //Console.WriteLine("\n \n What is your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello, " + name + "!");

            //Console.WriteLine("What course are you on?");
            //string course = Console.ReadLine();
            //Console.WriteLine("Hmm.. Sounds Boring!");

            //Console.WriteLine("What page number?");
            //int pageNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("So, you just started..");

            //Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            //string needHelp = Console.ReadLine();
            //bool needHelpBool = bool.Parse(needHelp);

            //Console.WriteLine("What experiences would you like to share? Be Specific People!!");
            //string experience = Console.ReadLine();
            //Console.WriteLine("Is that all?");

            //Console.WriteLine("Is there any feedback that you would like to provide?");
            //string feedBack = Console.ReadLine();

            //Console.WriteLine("How many hours did you study?");
            //string hour = Console.ReadLine();
            //int studyHoursNum = Convert.ToInt32(hour);
            //Console.WriteLine("Thank you " + name + " for your answers. An instructor will respond shortly. Have a great day!"); 
           

            Console.ReadKey();
        }
    }
}
