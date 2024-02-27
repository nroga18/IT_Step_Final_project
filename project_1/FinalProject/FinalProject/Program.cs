using FinalProject.Books;
using FinalProject.Students;
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

            //ShowBooksMenu();
            //TestBokMenu();

            //ShowStudentsMenu();
            TestStudentsMenu();

            Console.ReadLine(); 
        }
        public static void TestStudentsMenu()
        {
            var manager = new StudentManager();
            manager.AddStudent(new Student { Name = "Name1", RollNumber = 1, Grade = 'a' });
            manager.AddStudent(new Student { Name = "Name2", RollNumber = 5, Grade = 'c' });
            manager.DisplayAllStudents();
            var st = manager.FindStudentByNumber(1);
            Console.WriteLine(st);
            manager.UpdateGrade(st.RollNumber, 'c');
            Console.WriteLine(st);

        }
        public static void ShowStudentsMenu()
        {
            var manager = new StudentManager();
            while (true)
            {
                Console.WriteLine("1.Add new Student\n2.Display all students\n3.Find student\n4.Update grade\n5.Exit");
                var choise = int.Parse(Console.ReadLine());
                if (choise == 1)
                {
                    Console.Write("Enter student name: ");
                    var name = Console.ReadLine();
                    Console.Write("Enter Roll Number: ");
                    var rollNum = int.Parse(Console.ReadLine());
                    Console.Write("Enter Grade: ");
                    var grade = Console.ReadLine()[0];
                    manager.AddStudent(new Student { Name = name, RollNumber = rollNum, Grade = grade});
                }
                else if (choise == 2)
                {
                    manager.DisplayAllStudents();
                }
                else if (choise == 3)
                {
                    Console.Write("Enter roll number: ");
                    var num = int.Parse(Console.ReadLine());
                    var student = manager.FindStudentByNumber(num);
                    Console.WriteLine(student);
                }else if(choise == 4)
                {
                    Console.Write("Enter roll number: ");
                    var num = int.Parse(Console.ReadLine());
                    Console.Write("Enter Grade: ");
                    var gr = Console.ReadLine()[0];
                    var student = manager.FindStudentByNumber(num);
                    if(student == null)
                    {
                        Console.WriteLine("student was not found");
                    }
                    else
                    {
                        manager.UpdateGrade(num, gr);
                    }
                }
                else if(choise == 5)
                {
                    return;
                }
            }
        }
        public static void TestBokMenu()
        {
            var manager = new BookManager();
            manager.AddBook(new Book { Author = "Author1", Name = "Name1", ReleaseYear = 2000 });
            manager.AddBook(new Book { Author = "Author2", Name = "Name2", ReleaseYear = 2001 });
            manager.AddBook(new Book { Author = "Author3", Name = "Name3", ReleaseYear = 2003 });
            manager.DiplayBooks();
            var b = manager.FindBook("Author1");
            Console.WriteLine(b);
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
