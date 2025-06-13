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

            Console.WriteLine("What is your fav number?");
            string favNumber = Console.ReadLine();
            int favNum = Convert.ToInt32(favNumber);
            int total = favNum + 9;
            Console.WriteLine("Your fav Number plus 9 is: " + total);
            Console.ReadLine();
        }
    }
}
