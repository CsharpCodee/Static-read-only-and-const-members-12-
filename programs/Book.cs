using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic13._4
{
    public class Book
    {
        private readonly string isbn;

        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string isbn, string title, string author)
        {
            this.isbn = isbn; 
            Title = title;
            Author = author;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ISBN: {isbn}, название: {Title}, автор: {Author}");
        }
    }
}
