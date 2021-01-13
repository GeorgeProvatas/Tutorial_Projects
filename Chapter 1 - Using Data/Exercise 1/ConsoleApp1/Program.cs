using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a number");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("input a second number");
            int secondnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("the sum of numbers typed is " + (firstnumber + secondnumber));

        }
    }
}
