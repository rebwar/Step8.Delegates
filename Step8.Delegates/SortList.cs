namespace Step8.Delegates
{
    public class SortList
    {
        public int[] Sort(int[] array, SortStrategy sortStrategy)
        {
            for (int x = 0; x < array.Length; x++)
            {
                for (int y = x; y < array.Length; y++)
                {
                    if (sortStrategy(array[x], array[y]))
                    {
                        int temp = array[x];
                        array[x] = array[y];
                        array[y] = temp;
                    }
                }
            }
            return array;
        }
        public static bool SortAscending(int number1, int number2)
        {
            return number1 > number2;
        }

        public static bool SortDescending(int number1, int number2)
        {
            return number1 < number2;
        }
    }
}
