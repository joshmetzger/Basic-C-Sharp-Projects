using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car insurance approval app");
            Console.ReadLine();

            //get user info
            Console.WriteLine("Enter your age: ");
            string age = Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI? enter \"true\" or \"false\":");
            string DUI = Console.ReadLine();

            Console.WriteLine("enter the number of speeding tickets you have had: ");
            string numTix = Console.ReadLine();

            //convert data to needed data types
            int userAge = Convert.ToInt32(age);
            bool hasDUI = Convert.ToBoolean(DUI);
            int tixCount = Convert.ToInt32(numTix);

            //logic if user qualifies for insurance
            bool qualified = (userAge >= 18 && !hasDUI && tixCount <= 3);

            //print to screen
            Console.WriteLine("Qualified: " + qualified);
            Console.ReadLine();
        }
    }
}
