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
            Console.WriteLine("Choose action:\n1.View Balance\n2.Deposit\n3.Withdraw");
            var choise = int.Parse(Console.ReadLine());
            

            var folderName = "D:\\IT_Step\\project_1\\FinalProject\\BankAccounts\\";
            var fullPath = folderName + name + ".txt";

            try
            {
                var reader = new StreamReader(fullPath);
                var line = reader.ReadLine();
                if(choise == 1)
                {
                    var balance = int.Parse(line.Substring(line.IndexOf("Balance-")));
                    Console.WriteLine($"Your current balance is {balance}");
                }else if (choise == 1)
                {

                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }
    }
}
