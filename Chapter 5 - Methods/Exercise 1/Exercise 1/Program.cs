using System;

namespace Exercise_1
{
    class Program
    {
        public static void Multiplication_Table(int number)
        {
            for(int i = 2; i <= 10; i++)
            {
                int answer = number * i;
                Console.WriteLine($"{number} * {i} = {answer}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            int number = int.Parse(Console.ReadLine());
            Multiplication_Table(number);
        }
    }
}
