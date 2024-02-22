using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal static class RandomNumber
    {
        public static void GuessRandomNumber()
        {
            var random = new Random();
            var numOfTries = 10;
            var usedTries = 0;
            Console.Write("Enter start of the range:");
            var start = int.Parse(Console.ReadLine());
            Console.Write("Enter end of the range:");
            var end = int.Parse(Console.ReadLine());
            var randomNum = random.Next(start, end);
            while (usedTries < numOfTries)
            {
                Console.Write("Guess the random number: ");
                var guess = int.Parse(Console.ReadLine());
                usedTries++;
                if (guess == randomNum)
                {
                    Console.WriteLine($"You guessed the random number {randomNum} in {usedTries} tries");
                    return;
                }
                else
                {
                    
                    if (guess > randomNum)
                    {
                        Console.WriteLine($"your guess is higher than target");
                    }
                    else
                    {
                        Console.WriteLine($"your guess is less than target");
                    }
                }
            }

            Console.WriteLine("You have no more try");

        }
    }
}
