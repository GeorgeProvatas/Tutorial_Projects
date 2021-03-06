﻿using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RandomGenerator = new Random();
            int RandomNumber = RandomGenerator.Next(1, 11);

            Console.WriteLine("Guess the number!(1,10)");
            int PlayerNumber = int.Parse(Console.ReadLine());

            if (PlayerNumber > RandomNumber)
            {
                Console.WriteLine("Number generated by the CPU is {0}. Your number is higher", RandomNumber);
            }
            else if (PlayerNumber < RandomNumber)
            {
                Console.WriteLine("Number generated by the CPU is {0}. Your number is lower", RandomNumber);
            }
            else
            {
                Console.WriteLine("Number generated by the CPU is {0}. Exact match!!", RandomNumber);
            }
        }
    }
}
