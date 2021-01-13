using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int pricepersqfoot = 3;

            Console.WriteLine("Enter length of room");
            int roomlength = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter width of room");
            int roomwidth = int.Parse(Console.ReadLine());
            Console.WriteLine("price for carpenting the room is " +((roomlength * roomwidth) * pricepersqfoot));
        }
    }
}
