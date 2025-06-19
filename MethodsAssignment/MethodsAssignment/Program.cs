using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate Math object from class
            Math math = new Math();

            //get user input
            Console.WriteLine("Please enter a whole number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //use first Math method with user input
            int exponent = Math.Exponent(num);

            //display result:
            Console.WriteLine(exponent);

            //use second Math method with user input
            int sum = Math.Sum(num);

            //display result:
            Console.WriteLine(sum);

            //use second Math method with user input
            int diff = Math.Diff(num);

            //display result:
            Console.WriteLine(diff);


        }
    }
}
