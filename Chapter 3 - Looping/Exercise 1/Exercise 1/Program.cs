using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float payRate;

            do
            {
                Console.WriteLine("Please enter your hourly pay rate");
                payRate = float.Parse(Console.ReadLine());
            } while (payRate < 5.65 || payRate > 49.99);

            Console.WriteLine($"Your hourly pay rate is {payRate} dollars");
        }
    }
}
