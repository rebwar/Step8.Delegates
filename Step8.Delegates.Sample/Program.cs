using System;

namespace Step8.Delegates.Sample
{
    class Program
    {
        public delegate int SampleDelegate();
        static void Main(string[] args)
        {
             //CallSimpleMethod();
            //CallDelegateMethods();
           // UseMultiCast();
            ReturnedDelegate();
        }

        private static void ReturnedDelegate()
        {
            SampleDelegate del = new SampleDelegate(MethodOne);
            del += MethodTwo;
            //int ValueReturnedByDelegate = del();
            //Console.WriteLine("Returned Value = {0}", ValueReturnedByDelegate);
            foreach (var item in del.GetInvocationList())
            {

                Console.WriteLine("Returned Value = {0}", item.DynamicInvoke());
            }
        }

        public static int MethodOne()
        {
            return 1;
        }
        // This method returns two
        public static int MethodTwo()
        {
            return 2;
        }

        private static void UseMultiCast()
        {
            MathSample math = new MathSample();
            var D1 = new MathSample.MathDelegate(MathSample.Add);
            var D2 = new MathSample.MathDelegate(MathSample.Sub);
            var D3 = new MathSample.MathDelegate(math.Mul);
            var D4 = new MathSample.MathDelegate(math.Div);
            MathSample.MathDelegate D5 = D1 + D2 + D3 + D4;
            D5.Invoke(50, 10);
            

        }

        private static void CallDelegateMethods()
        {
            DelegateClass delegateClass = new DelegateClass();
            DelegateClass.AddDelegate ad = new DelegateClass.AddDelegate(delegateClass.Add);
            DelegateClass.SayHelloDelegate gd = new DelegateClass.SayHelloDelegate(DelegateClass.SayHello);
            ad(100, 500);
            Console.WriteLine(gd("Dude!"));
        }

        private static void CallSimpleMethod()
        {
            SampleClass sample = new SampleClass();
            sample.Add(20, 30);
            Console.WriteLine(SampleClass.SayHello("Dude!"));
        }
    }
}
