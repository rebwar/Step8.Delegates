using System;
using System.Collections.Generic;
using System.Text;

namespace Step8.Delegates.Sample
{
   public class DelegateClass
    {
        public delegate void AddDelegate(int a, int b);
        public delegate string SayHelloDelegate(string name);
        public void Add(int x, int y)
        {
            Console.WriteLine($"{x} + {y} ={x + y}");
        }
        public static string SayHello(string name)
        {
            return "Hello " + name;
        }
    }
}
