using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1,11);

            Console.WriteLine("Guessing game has begun! Guess the number!!! (1 - 10)");
            int userGuess = int.Parse(Console.ReadLine());
            int amountofGuesses = 0;
            do
            {
                randomNumber = randomGenerator.Next(1, 11);

                if (randomNumber < userGuess)
                {
                    Console.WriteLine($"CPU generated number is {randomNumber}. Your guess was {userGuess}. Your guess was higher, try again!");
                    userGuess = int.Parse(Console.ReadLine());
                }
                else if (randomNumber > userGuess)
                {
                    Console.WriteLine($"CPU generated number is {randomNumber}. Your guess was {userGuess}. Your guess was lower, try again!");
                    userGuess = int.Parse(Console.ReadLine());
                }
                amountofGuesses++;
            } while (randomNumber != userGuess);

            Console.WriteLine($"CPU generated number is {randomNumber}. Your guess was {userGuess}. Congrats you won!!!");
            Console.WriteLine($"You guessed the correct answer in {amountofGuesses} tries!");
            Console.ReadLine();
        }
    }
}
