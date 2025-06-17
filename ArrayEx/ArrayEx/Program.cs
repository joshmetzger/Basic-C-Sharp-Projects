using System;
using System.Collections.Generic;
using System.Dynamic;


class Program
{
    static void Main()
    {
        // create an array and instantiate the array object inline.
        string[] stringArray = new string[] { "blorf", "boff", "beedf", "piff" };

        //convert user's guess into int
        Console.WriteLine("Enter a number between 0 - " + (stringArray.Length - 1));
        int number = Convert.ToInt32(Console.ReadLine());
        // handle if user enters number greater than the length of array
        if (number > (stringArray.Length - 1))
        {
            Console.WriteLine("Please try again, enter a number between 0 - " + (stringArray.Length - 1));
            number = Convert.ToInt32(Console.ReadLine());
        }
        else
        {
            //use guess as array index and print out
            Console.WriteLine(stringArray[number]);
        }


        // create an array and instantiate the array object inline.
        int[] intArray = new int[] { 300, 15, 86, 75, 100 };

        //convert user's guess into int
        Console.WriteLine("Enter a number between 0 - " + (intArray.Length - 1));
        int num = Convert.ToInt32(Console.ReadLine());
        // handle if user enters number greater than the length of array
        if (num > (intArray.Length - 1))
        {
            Console.WriteLine("Please try again, enter a number between 0 - " + (intArray.Length - 1));
            num = Convert.ToInt32(Console.ReadLine());
        }
        else
        {
            //use guess as array index and print out
            Console.WriteLine(intArray[num]);
        }

        //CreateInstanceBinder and initialize string list
        List<string> strList = new List<string>();

        strList.Add("dsfkjn");
        strList.Add("Yo");
        strList.Add("Yes");
        strList.Add("stringing");

        //convert user's guess into int
        Console.WriteLine("Enter a number between 0 - 3");
        int index = Convert.ToInt32(Console.ReadLine());
        // handle if user enters number greater than the length of array
        if (index > 3)
        {
            Console.WriteLine("Please try again, enter a number between 0 - 3");
            index = Convert.ToInt32(Console.ReadLine());
        }
        else
        {
            //use guess as array index and print out
            Console.WriteLine(strList[index]);
        }
    }
}
