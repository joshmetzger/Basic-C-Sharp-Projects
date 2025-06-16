using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            //get package weight
            Console.WriteLine("Enter weight of your package: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }

            //get remaining package dimensions
            Console.WriteLine("Enter width of your package: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height of your package: ");
            double height = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter length of your package: ");
            double length = Convert.ToDouble(Console.ReadLine());

            //check if these dimensions > 50
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }

            // determine total cost and print
            double quote = ((height * width * length) * weight) / 100;

            Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
            Console.ReadLine();

        }
    }
}
