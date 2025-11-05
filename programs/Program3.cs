using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic13._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObjectCounter obj1 = new ObjectCounter();
            ObjectCounter obj2 = new ObjectCounter();
            ObjectCounter.DisplayObjectCount();
            Console.WriteLine();
        }
    }
}
