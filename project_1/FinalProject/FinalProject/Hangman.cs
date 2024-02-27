using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal static class Hangman
    {
        public static List<String> words = new List<String>()
        {
            "coffee",
            "banana",
            "airport",
            "cryptography",
            "computer",
        };
        public static void Game()
        {
            var random = new Random();
            var numOfTries = 20;
            var numOfUsedTries = 0;
            var ind = random.Next(words.Count);
            var randomWord = words[ind];
            var arr = new bool[randomWord.Length];
            for (int i = 0; i < randomWord.Length; i++)
            {
                arr[i] = false;
            }
            Console.WriteLine($"Guess the word: {GetWord(randomWord, arr)}");
            while (numOfUsedTries != numOfTries)
            {
                Console.Write("Enter character: ");
                var ch = Console.ReadKey().KeyChar;
                Console.WriteLine();
                numOfUsedTries++;
                for (int i = 0; i < randomWord.Length; i++)
                {
                    if (randomWord[i] == ch && arr[i] == false)
                    {
                        arr[i] = true;
                    }
                }
                Console.WriteLine(GetWord(randomWord, arr));
                if (IsWordGuessed(arr))
                {
                    Console.WriteLine($"You Guessed the word in {numOfUsedTries} tries");
                    return;
                }
            }
            Console.WriteLine("Game Over");
        } 
        public static bool IsWordGuessed(bool[] arr)
        {
            return !arr.Contains(false);
        }
        public static string GetWord(string word, bool[] guessedChars)
        {
            var res = "";
            for(int i = 0; i< word.Length; i++)
            {
                if (guessedChars[i])
                {
                    res += word[i];
                }
                else
                {
                    res += "_";
                }
                res += " ";
                
            }
            return res;
        }
    }
}
