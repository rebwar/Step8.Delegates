using System;
using System.Collections.Generic;
using System.Text;

namespace Step8.Delegates
{
   public static class OperationDelegate
    {
        public delegate void MethodPointer(int number1, int number2);
        public static void Sum(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }

        public static void Substract(int number1, int number2)
        {
            Console.WriteLine(number1 - number2);
        }
    }
}
