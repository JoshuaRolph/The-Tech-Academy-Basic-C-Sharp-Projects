using System;
using System.Collections.Generic;


    class Program
    {
        static void Main()
        {
        //List<string> intList = new List<string>();
        //intList.Add("Hello");
        //intList.Add("Joshua");
        //intList.Remove("Joshua");

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();

        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //Console.WriteLine(numArray[3]);
        //Console.ReadLine();

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };
        //Console.WriteLine(numArray[3]);
        //Console.ReadLine();

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();

        //// Number Array Assignment... //
        string[] numArray = { "10", "20", "40", "80", "160", "320", "640" };
        // Asking user to pick a number between 0 and 6.. //
        Console.WriteLine("Pick a number between 0 and 6.");
        int number = Convert.ToInt32(Console.ReadLine());
        bool number1 = false;

        while (!number1)
        {
            try
            {
                Console.WriteLine("Your Number Choice Is..." + numArray[number]);
                number1 = true;
                Console.ReadLine();
            }
            // Catch if the number they type up is not valid. //
            catch
            {
                Console.WriteLine("Your choice is INVALID! Try again and pick between 0 and 6...");
                number = Convert.ToInt32(Console.ReadLine());
            }

        }

        //List<string> movies = new List<string>()
        //    { "Harry and the Henderson's",
        //         "Dracula",
        //         "Gremlins",
        //         "Gladiator",
        //         "World War Z"
        //        };
        //Console.WriteLine("\n Pick a random number between 0 and 4.");


        //int listSelect = Convert.ToInt32(Console.ReadLine());
        //bool validlist = false;

        //while (!validlist)
        //{
        //    try
        //    {
        //        Console.WriteLine("The next movie to watch is: " + movies[listSelect]);
        //        validlist = true;
        //    }

        //    catch
        //    {
        //        Console.WriteLine("Wrong choice! Try again..");
        //        listSelect = Convert.ToInt32(Console.ReadLine());
        //    }
        //}




    }
}

