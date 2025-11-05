using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic13._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.add(6, 3));
            Console.WriteLine(Calculator.substraction(26, 31));
            Console.WriteLine(Calculator.myltiplication(9, 9));
            Console.WriteLine(Calculator.division(6, 0));
        }
    }
}
