using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Books
{
    public class BookManager
    {
        public List<Book> books = new List<Book>()
        {

        };
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void DiplayBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }
        public Book FindBook(string name)
        {
            return books.Find(x => x.Name == name);
        }
    }
}
