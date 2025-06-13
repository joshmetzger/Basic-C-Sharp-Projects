using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //intro
            Console.WriteLine("The Tech Academy");
            Console.ReadLine();
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            //get student name
            Console.WriteLine("What is your name?");
            //save student name
            string uName = Console.ReadLine();

            // get student current course
            Console.WriteLine("What course are you on?");
            //save current course
            string cName = Console.ReadLine();

            // get student current page number
            Console.WriteLine("What page number?");
            // save to string
            string pNumber = Console.ReadLine();
            //convert to int
            int pNum = Convert.ToInt32(pNumber);

            //is help needed
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            //save
            string help = Console.ReadLine();
            //convert
            bool needHelp = Convert.ToBoolean(help);

            //get experience
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            //save
            string experience = Console.ReadLine();

            //get feedback
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            //save
            string feedback = Console.ReadLine();

            // get study hours
            Console.WriteLine("How many hours did you study today?");
            // save to string
            string sNumber = Console.ReadLine();
            //convert to int
            int sNum = Convert.ToInt32(sNumber);

            //outro
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
