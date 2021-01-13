using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your hourly pay rate");
            double HourlyPayRate = double.Parse(Console.ReadLine());

            if (HourlyPayRate < 7.50 || HourlyPayRate > 49.00)
            {
                Console.WriteLine("Error message");
            }
            else
            {
                Console.WriteLine("Pay rate is ok");
            }
        }
    }
}
