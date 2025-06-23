using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //double an integer from class MyMath method
            //int sum = MyMath.Double(5);
            //Console.WriteLine(sum);

            //double a decimal from class MyMath method
            //decimal sum2 = MyMath.Double(10.9472m);
            //Console.WriteLine(sum2);

            //double a integer that was passed to the method as a string from class MyMath method
            decimal sum3 = MyMath.Double("10");
            Console.WriteLine(sum3);
        }
    }
}
