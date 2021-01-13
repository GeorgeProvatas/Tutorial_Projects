using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zipCode = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            Console.WriteLine("Enter your zip code");
            int userZipCode = int.Parse(Console.ReadLine());
            bool isThere = false;

            for(int i = 0; i < zipCode.Length; i++)
            {
                if(userZipCode == zipCode[i])
                {
                    
                    isThere = true;
                    break;
                }
            }
            if(isThere == true)
            {
                Console.WriteLine("we can deliver to the specified postal code");
            }
            else
            {
                Console.WriteLine("we CANNOT deliver to the specified postal code");
            }



        }
    }
}
