using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            // gather person1 info
            Console.WriteLine("Person1");

            Console.WriteLine("Enter your hourly rate: ");
            string rate1 = Console.ReadLine();

            Console.WriteLine("Enter your hours worked this week: ");
            string hours1 = Console.ReadLine();


            // gather person2 info
            Console.WriteLine("Person2");

            Console.WriteLine("Enter your hourly rate: ");
            string rate2 = Console.ReadLine();

            Console.WriteLine("Enter your hours worked this week: ");
            string hours2 = Console.ReadLine();

            //convert to num and calculate annual salary person1
            double p1rate = Convert.ToDouble(rate1);
            double p1hours = Convert.ToDouble(hours1);

            double p1salary = (p1rate * p1hours) * 52;

            //print to screen
            Console.WriteLine("Person1 salary is: " + p1salary);


            //convert to num and calculate annual salary person2
            double p2rate = Convert.ToDouble(rate2);
            double p2hours = Convert.ToDouble(hours2);

            double p2salary = (p2rate * p2hours) * 52;

            //print to screen
            Console.WriteLine("Person2 salary is: " + p2salary);


            //compare and print to screen
            bool compare = p1salary > p2salary;
            string salaryCompare = Convert.ToString(compare);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(salaryCompare);




        }
    }
}
