using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal static class BankcAccounts
    {
        public class Account
        {
            public string Name { get; set; }
            public double Balance { get; set; }
        }
        public static void Start()
        {
            Console.Write("Enter Name: ");
            var name = Console.ReadLine();
            var folderName = "D:\\IT_Step\\project_1\\FinalProject\\BankAccounts\\";
            var fullPath = folderName + name + ".txt";

            try
            {
                while (true)
                {
                    Console.WriteLine("Choose action:\n1.View Balance\n2.Deposit\n3.Withdraw");
                    var choise = int.Parse(Console.ReadLine());

                    var reader = new StreamReader(fullPath);
                    var line = reader.ReadLine();
                    reader.Close();
                    var balance = int.Parse(line.Substring(line.IndexOf("Balance-") + 8));
                    if (choise == 1)
                    {
                        Console.WriteLine($"Your current balance is {balance}");
                    }
                    else if (choise == 2)
                    {
                        Console.Write($"Enter deposit amount: ");
                        var amt = int.Parse(Console.ReadLine());
                        balance += amt;
                        var writer = new StreamWriter(fullPath);
                        var content = line.Substring(0, line.IndexOf("Balance-") + 8) + balance;
                        writer.WriteLine(content);
                        writer.Close();
                        Console.WriteLine($"Your current balance is {balance}");
                    }
                    else if (choise == 3)
                    {
                        Console.Write($"Enter withdraw amount: ");
                        var amt = int.Parse(Console.ReadLine());
                        balance -= amt;
                        var writer = new StreamWriter(fullPath);
                        var content = line.Substring(0, line.IndexOf("Balance-") + 8) + balance;
                        writer.WriteLine(content);
                        writer.Close();
                        Console.WriteLine($"Your current balance is {balance}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }
    }
}
