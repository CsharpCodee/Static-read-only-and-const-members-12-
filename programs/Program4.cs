using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic13._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("978-3-16-148410-0", "Программирование на C#", "Марта Кол");
            book1.DisplayInfo();
            Console.WriteLine();
        }
    }
}
