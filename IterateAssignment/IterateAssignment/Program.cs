using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace IterateAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iterate Assignment part 1
            string[] animals = { "cat", "dog", "frog", "rabbit" };

            //get user text input
            Console.WriteLine("Enter some text: ");
            string userText = Console.ReadLine();

            //Iterate through array
            for (int i = 0; i < animals.Length; i++)
            {
                // add user text to each string in array
                animals[i] = animals[i] + ' ' + userText;
            }

            //Print each string in array
            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }
            Console.ReadLine();

            //Iterate Assignment part 2
            //infiinite loooooooop
            //while (true)
            //{
            //    Console.WriteLine("forever loop");
            //}

            //fixed infinite by setting number limit
            int limit = 5;
            int num = 0;
            while (num < limit)
            {
                Console.WriteLine("not forever loop " + num);
                num++;
            }
            Console.ReadLine();

            //Iterate Assignment part 3
            //loop compare with <
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine("less than the limit at: " + i);
            }
            Console.ReadLine();

            //loop compare with <=
            for (int i = 0; i <= limit; i++)
            {
                Console.WriteLine("less than the limit at: " + i);
            }
            Console.ReadLine();

            //Iterate Assignment part 4
            List<string> plants = new List<string>() { "flower", "tree", "cactus", "vine", "bush" };

            //get user text
            Console.WriteLine("enter plant guess: ");
            string plantGuess = Console.ReadLine();

            bool match = false;

            for (int i = 0; i < plants.Count; i++)
            {
                //print index of the matched list item if found, break loop.
                if (plants[i] == plantGuess)
                {
                    Console.WriteLine(i);
                    match = true;
                    break;
                }
                
            }

            // with no match, give message to user.
            if(!match)
            {
                Console.WriteLine("Sorry no match");
            }
            Console.ReadLine();


            //Iterate Assignment part 5
            List<string> trees = new List<string>() { "oak", "maple", "elm", "maple", "palm" };

            // get user guess
            Console.WriteLine("enter tree guess: ");
            string treeGuess = Console.ReadLine();

            match = false;

            for (int i = 0; i < trees.Count; i++)
            {
                //print index of the matched list item if found, break loop.
                if (trees[i] == treeGuess)
                {
                    Console.WriteLine(i);
                    match = true;
                }

            }

            // with no match, give message to user.
            if (!match)
            {
                Console.WriteLine("Sorry no match");
            }
            Console.ReadLine();


            //Iterate Assignment part 6
            // uses trees array from above
            
            //create new list to use as refernce
            List<string> trees2 = new List<string>() { };

            foreach (string tree in trees)
            {
                //check if item exits already in second list. print apropriate message for either case.
                if (trees2.Contains(tree))
                {
                    Console.WriteLine(tree + " - this item is a duplicate");
                }
                else
                {
                    Console.WriteLine(tree + " - this item is unique");
                }
                    
                // add to second list
                trees2.Add(tree);
                
            }

            Console.ReadLine();



        }
    }
}
