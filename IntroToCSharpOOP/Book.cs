using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharpOOP
{
    class Book
    {
        public string title;
        public string description;
        public string author;
        public int pages;

        public void read()
        {
            Console.WriteLine(this.pages);
        }


        public Book(string title, string description, string author, int pages) {
            this.title = title;
            this.description = description;
            this.author = author;
            this.pages = pages;
        }

    
    }
}
