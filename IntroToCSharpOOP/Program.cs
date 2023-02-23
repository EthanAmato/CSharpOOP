using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Harry Potter", "Book about some kid", "J.K. Rowling", 500);
            Book book2 = new Book("Harry Potter 2", "Book about some kid again", "J.K. Rowling", 1000);
            Console.WriteLine(book2);
            Library library = new Library();
            library.addBook(book);
            library.addBook(book2);
            Console.WriteLine(library);

            Book harrypotter = library.borrowBook("Harry Potter");
            harrypotter.read();
        }
    }
}