using System;

namespace Step8.Delegates
{
    public delegate bool SortStrategy(int number1, int number2);

    class Program
    {
        static void Main(string[] args)
        {
            // SortSample();
            MultiCast();
            Console.ReadKey();
        }

        private static void MultiCast()
        {
            OperationDelegate.MethodPointer pointer = OperationDelegate.Sum;
            pointer += OperationDelegate.Substract;

            pointer(8, 3);
        }

        private static void SortSample()
        {
            int[] numbers = { 2, 3, 6, 9, 7, 8, 5, 2, 3, 6, 9 };

            var sortList = new SortList();

            foreach (var item in sortList.Sort(numbers, SortList.SortDescending))
            {
                Console.WriteLine(item);
            }
        }
    }
}
