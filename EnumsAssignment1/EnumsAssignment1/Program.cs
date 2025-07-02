using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            bool correct = false;
            string input;
            do
            {
                // ask user input
                Console.WriteLine("Enter the current day of the week: ");

                // save user input to enum type DaysOfWeek
                input = Console.ReadLine();

                try
                {
                    // check and cast correct format input to DaysOfWeek
                    Days.DaysOfWeek today = (Days.DaysOfWeek)Enum.Parse(typeof(Days.DaysOfWeek), input);
                    Console.WriteLine("Thank you!");
                    correct = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please enter a day of the week (Monday, Tuesday, Wednesday, etc...): ");
                }
            }
            while (!correct);

        }
    }
}
