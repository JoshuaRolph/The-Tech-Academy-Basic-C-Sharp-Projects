using System;


namespace Daily_Report_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            //This is the code for your name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            //The next line is for the course
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            //Used int pageNum to allow number answers
            Console.WriteLine("What page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());
            //Asking if the student needs help with the selected course.
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            bool needHelpBool = bool.Parse(needHelp);
            //Inputted code to receive positive feedback
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            //Including negative feedback.
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string feedBack = Console.ReadLine();
            //Hours studied today
            Console.WriteLine("How many house did you study today?");
            string studyHours = Console.ReadLine();
            int studyHoursNum = Convert.ToInt32(studyHours);
            //Thanking the student for submitting their information.
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!!");
            Console.ReadLine();
        }
    }
}
