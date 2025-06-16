using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string youName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + youName);
            //Console.ReadLine();

            //Console.WriteLine("What is your fav number?");
            //string favNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favNumber);
            //int total = favNum + 9;
            //Console.WriteLine("Your fav Number plus 9 is: " + total);
            //Console.ReadLine();

            int num1 = 34;
            int num2 = 700;
            int total1 = num1 + num2;
            Console.WriteLine(total1);

            int num3 = 34;
            int num4 = 700;
            int total2 = num4 - num3;
            Console.WriteLine(total2);

            int num5 = 3;
            int num6 = 70;
            int total3 = num5 * num6;
            Console.WriteLine(total3);

            int num7 = 34;
            int num8 = 17;
            int total4 = num7 / num8;
            Console.WriteLine(total4);

            string fname = "Yoshy";
            decimal dec = 84.930134729232m;
            Console.WriteLine(dec + fname );


        }
    }
}
