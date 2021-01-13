using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in the total amount of time passed in minutes only");
            int totalamountoftimepassed = int.Parse(Console.ReadLine());

            int RemainingHours = totalamountoftimepassed / 60;
            int RemainingMinutes = totalamountoftimepassed % 60;
            Console.WriteLine("The total amount of time passed in {0} minutes is equal to {1} hours and {2} minutes", totalamountoftimepassed, RemainingHours, RemainingMinutes);
        }
    }
}
