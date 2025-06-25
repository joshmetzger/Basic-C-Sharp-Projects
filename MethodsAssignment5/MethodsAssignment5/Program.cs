using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate a new object 
            MyMath mymath = new MyMath();

            // get user input
            Console.WriteLine("enter an integer which will be divided by 2: ");
            int input = Convert.ToInt32(Console.ReadLine());

            //call the divide method on the object with the user input as the argument
            mymath.DivideByTwo(input);

            //call the divide method on overload version
            mymath.DivideByTwo(12.4);

            // print
            Console.WriteLine(mymath);

            // call method from static class
            Print.PrintLine("award winning message!");

        }
    }
}
