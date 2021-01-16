using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum(5);
            Sum(5, 6, 8);
            Sum(5, 7, 3, 7, 9);
            int[] myArray = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 1};
            Sum(myArray);
        }

        public static void Sum(params int[] array)
        {
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"the sum is {sum}");
        }
    }
}
