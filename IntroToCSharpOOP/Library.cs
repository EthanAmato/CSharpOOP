using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharpOOP
{
    class Library
    {

        int numBooks;
        List<Book> heldBooks;

        public void addBook(Book book)
        {
            heldBooks.Add(book);
        }

        public Book? borrowBook(string bookName)
        {
            foreach (Book book in heldBooks)
            {
                if (book.title.Equals(bookName))
                {
                    heldBooks.Remove(book);
                    return book;
                }
            }
            return null;
        }

        public List<Book> getBooks()
        {
            Console.WriteLine(string.Join(",", heldBooks));
            return heldBooks;
        }

        public Library() { 
            this.heldBooks = new List<Book>();
            this.numBooks = 0;
        }

        public override string ToString()
        {
            return $"[{string.Join(",", heldBooks)}]";
        }
    }
}
