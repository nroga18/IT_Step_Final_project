using FinalProject.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculator.CallCalculator();
            //RandomNumber.GuessRandomNumber();
            //Hangman.Game();
            //Dictionary.Start();
            //BankcAccounts.Start();
            ShowBooksMenu();

            Console.ReadLine(); 
        }
        public static void ShowStudentsMenu()
        {

        }
        public static void ShowBooksMenu()
        {
            var manager = new BookManager();

            while (true)
            {
                Console.WriteLine("1.Add new book\n2.Display all books\n3.Find book");
                var choise = int.Parse(Console.ReadLine());
                if (choise == 1)
                {
                    Console.Write("Enter book name: ");
                    var name = Console.ReadLine();
                    Console.Write("Enter book Author: ");
                    var author = Console.ReadLine();
                    Console.Write("Enter book release year: ");
                    var year = int.Parse(Console.ReadLine());
                    manager.AddBook(new Book { Name = name, Author = author, ReleaseYear = year });
                }
                else if (choise == 2)
                {
                    manager.DiplayBooks();
                }
                else if (choise == 3)
                {
                    Console.Write("Enter book name: ");
                    var name = Console.ReadLine();
                    var book = manager.FindBook(name);
                    Console.WriteLine(book);
                }
            }
        }
    }
    
}
