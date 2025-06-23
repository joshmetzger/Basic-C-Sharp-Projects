using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignments3
{
    class Program
    {
        static void Main(string[] args)
        {
            //use MyMath class method to add two integers:
            //int sum = MyMath.Add(2);
            //Console.WriteLine(sum);

            // prompt user to enter integers. ony the first integer is required.
            Console.WriteLine("You will be prompted to enter two integers. only the first integer is required, you can skip the second one." +
                "Enter an integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            //get second optional integer from user
            Console.WriteLine("Enter a second integer (press enter to skip): ");
            string input = Console.ReadLine();

            int sum;
            if (string.IsNullOrWhiteSpace(input))
            {
                sum = MyMath.Add(num1);
            }
            else
            {
                int num2 = Convert.ToInt32(input);
                sum = MyMath.Add(num1, num2);
            }
            Console.WriteLine(sum);            

        }
    }
}
