using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lot length");
            double LotLength = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter lot width");
            double LotWidth = double.Parse(Console.ReadLine());

            double LotSquareFeet = LotLength * LotWidth;

            if (LotSquareFeet < 400)
            {
                Console.WriteLine("Weekly fee for mowing the lot is {0}$. Total fee is {1}$", LotSquareFeet * 25, (LotSquareFeet * 25) * 20);
            }
            else if (LotSquareFeet >= 400 && LotSquareFeet < 600)
            {
                Console.WriteLine("Weekly fee for mowing the lot is {0}$. Total fee is {1}$", LotSquareFeet * 35, (LotSquareFeet * 35) * 20);
            }
            else if (LotSquareFeet > 600)
            {
                Console.WriteLine("Weekly fee fro mowing the lot is {0}$. Total fee is {1}$", LotSquareFeet * 50, (LotSquareFeet * 50) * 20);
            }
        }
    }
}
