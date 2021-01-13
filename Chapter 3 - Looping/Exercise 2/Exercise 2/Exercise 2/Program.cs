using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int sum = 0;
            for(x = 1;x <= 50; x++)
            {
                sum = sum + x; //sum += x;
            }

            Console.WriteLine(sum);
        }
    }
}
