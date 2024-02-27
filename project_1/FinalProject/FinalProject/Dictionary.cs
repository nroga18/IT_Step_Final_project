using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinalProject
{
    internal static class Dictionary
    {
        public static void Start()
        {
            Console.Write("Enter From language: ");
            var from = Console.ReadLine();
            Console.Write("Enter To language: ");
            var to = Console.ReadLine();
            var fileName = from + to;

            var folderName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Dictionary\\");
            var fullPath = Path.Combine(folderName,fileName + ".txt");
            while (true)
            {
                Console.Write("Enter word to translate: ");
                var word = Console.ReadLine();
                var found = false;
                try
                {
                    if(!File.Exists(fullPath))
                    {
                        var fs = File.Create(fullPath);
                        fs.Close();
                        
                    }
                    var reader = new StreamReader(fullPath);
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        if (line.StartsWith(word))
                        {
                            var res = line.Substring(line.IndexOf(" - ") + 3);
                            Console.WriteLine($"your word is {res} in {to}");
                            found = true;
                            break;
                        }
                        line = reader.ReadLine();
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                if (!found)
                {
                    Console.WriteLine("your word was not found in dictionary, do you want to add it? y/n: ");
                    var write = Console.ReadLine();
                    if(write == "y")
                    {
                        Console.Write("Enter Translation: ");
                        var translation = Console.ReadLine();
                        try
                        {
                            var writer = new StreamWriter(fullPath,true);
                            writer.WriteLine($"{word} - {translation}");
                            writer.Close();
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("Exception: " + e.Message);
                        }
                    }
                }

            }
        }
    }
}
