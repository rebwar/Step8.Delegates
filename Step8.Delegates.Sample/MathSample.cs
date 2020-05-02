using System;
using System.Collections.Generic;
using System.Text;

namespace Step8.Delegates.Sample
{
    public class MathSample
    {
        public delegate void MathDelegate(int No1, int No2);
        public static void Add(int x, int y)
        {
            Console.WriteLine("THE SUM IS : " + (x + y));
        }
        public static void Sub(int x, int y)
        {
            Console.WriteLine("THE SUB IS : " + (x - y));
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine("THE MUL IS : " + (x * y));
        }
        public void Div(int x, int y)
        {
            Console.WriteLine("THE DIV IS : " + (x / y));
        }

    }
}
