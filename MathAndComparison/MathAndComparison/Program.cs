using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;

            //Console.WriteLine("Five plus Ten = " + total);
            //Console.ReadLine();

            //int total = 10 - 5;

            //Console.WriteLine("Ten minus Five = " + total);
            //Console.ReadLine();


            //get number
            Console.WriteLine("enter any number: ");
            //save number
            string num1 = Console.ReadLine();
            //convert to num and * 50
            int number1 = Convert.ToInt32(num1) * 50;
            Console.WriteLine("the new number is: " + number1);
            Console.ReadLine();


            //get number
            Console.WriteLine("enter any number: ");
            //save number
            string num2 = Console.ReadLine();
            //convert to num and add 25
            int number2 = Convert.ToInt32(num2) + 25;
            Console.WriteLine("the new number is: " + number2);
            Console.ReadLine();

            //get number
            Console.WriteLine("enter any number: ");
            //save number
            string num3 = Console.ReadLine();
            //convert to num and divide by 12.5
            double number3 = Convert.ToDouble(num3) / 12.5;
            Console.WriteLine("the new number is: " + number3);
            Console.ReadLine();

            //get number
            Console.WriteLine("enter any number: ");
            //save number
            string num4 = Console.ReadLine();
            //convert to num, divde by 7, print remainder.
            double number4 = Convert.ToDouble(num4) % 7;
            Console.WriteLine("the remainder is: " + number4);
            Console.ReadLine();


        }
    }
}
