using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Harry Potter", "Book about some kid", "J.K. Rowling", 500);
            book.read();
        }
    }
}