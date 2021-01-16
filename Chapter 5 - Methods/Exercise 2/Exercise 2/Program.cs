using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            int number = int.Parse(Console.ReadLine());
            int squared = Square(number);
            int cubed = Cube(number);
            Console.WriteLine($"the square number is {squared} and the cube number is {cubed}");
        }

        public static int Square(int number)
        {
            int answer = number * number;
            return answer;
        }

        public static int Cube(int number)
        {
            Square(number);
            int answer = Square(number) * number;
            return answer;
        }
    }
}
