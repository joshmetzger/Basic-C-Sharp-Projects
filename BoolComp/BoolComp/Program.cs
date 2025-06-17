using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolComp
{
    class Program
    {
        static void Main(string[] args)
        {
            // begin prgram with winning animal name. isGuessed true if guess =  zebra.
            Console.WriteLine("Guess the animal: ");
            string guess = Console.ReadLine();
            bool isGuessed = guess == "zebra";

            // while isGuessued false, continue to take user's guesses until they enter zebra.
            do
            {
                switch (guess)
                {
                    case "cat":
                        Console.WriteLine("wrong animal, not cat, guess again");
                        Console.WriteLine("Guess the animal: ");
                        guess = Console.ReadLine();
                        break;
                    case "hippo":
                        Console.WriteLine("wrong animal, not hippo, guess again");
                        Console.WriteLine("Guess the animal: ");
                        guess = Console.ReadLine();
                        break;
                    case "squid":
                        Console.WriteLine("wrong animal, not squid, guess again");
                        Console.WriteLine("Guess the animal: ");
                        guess = Console.ReadLine();
                        break;
                    // once isGuessed is true, end program.
                    case "zebra":
                        Console.WriteLine("Correct! it is zebra.");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("wrong animal guess again");
                        Console.WriteLine("Guess the animal: ");
                        guess = Console.ReadLine();
                        break;

                }
            }
            while (!isGuessed);
            
        }
    }
}
