using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticaseDelegate
{
    public delegate void MathOperation(int a, int b);
    internal class MathOpe
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        public static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
}
