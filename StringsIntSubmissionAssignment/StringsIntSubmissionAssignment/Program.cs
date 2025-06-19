using System;
using System.Collections.Generic;

namespace StringsIntSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>() { 15, 25, 20, 10, 2, 100, 25, 76 };

            while (true)
            {
                // exception handling for possible user errors:
                try
                {
                    // get user input
                    Console.WriteLine("Enter a whole number to divide a list of numbers by: ");
                    int userNum = Convert.ToInt32(Console.ReadLine());

                    // divide each number in the list by userNum
                    foreach (int num in numList)
                    {
                        Console.WriteLine("result: " + num / userNum);
                    }
                }
                // user enters a number that isn't whole:
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter only a whole number.");
                    continue;
                }
                // user enters a 0:
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Cannot divide by zero, please enter only a whole number.");
                    continue;
                }
                // just in case we left anything out:
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                // always do this. also Log any info.
                finally
                {
                    Console.ReadLine();
                }
                break;
            }
            
        }
    }
}
