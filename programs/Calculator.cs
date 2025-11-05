using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic13._1
{
    abstract class Calculator
    {
        public static string add(int a, int b)
        {
            return $"{a} + {b} = {a+b}";
        }
        public static string substraction(int a, int b)
        {
            return $"{a} - {b} = {a - b}";
        }
        public static string myltiplication(int a, int b)
        {
            return $"{a} x {b} = {a * b}";
        }
        public static string division(int a, int b)
        {
            if (a != 0 && b != 0)
            {
                return $"{a} / {b} = {a / b}";
            }
            else
            {
                return "Деление на 0 невозможно.";
            }
        }
    }
}
