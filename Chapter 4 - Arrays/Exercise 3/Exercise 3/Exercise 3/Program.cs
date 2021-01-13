using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = { "sketch", "billiards", "exhaust", "window", "square", "colorful", "background", "guitar" };

            Random randomInstance = new Random();
            int randomNumber = randomInstance.Next(0,words.Length);

            string selectedWord = words[randomNumber];
            string hiddenWord = "" ;
            for(int i = 0; i < selectedWord.Length; i++)
            {
                hiddenWord += "*";
            }
            while (hiddenWord.Contains("*"))
            {
                Console.WriteLine($"Word : {hiddenWord}");
                Console.Write("Guess a letter!! --> ");
                Char letter = char.Parse(Console.ReadLine());
                bool containsLetter = false;
                for(int i = 0; i < selectedWord.Length; i++)
                {
                    if(letter == selectedWord[i])
                    {
                       hiddenWord =  hiddenWord.Remove(i, 1);
                       hiddenWord =  hiddenWord.Insert(i, letter.ToString());
                        containsLetter = true;
                    }
                }
                if(containsLetter == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Yes!!! The letter {letter} is in the word!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sorry, the letter {letter} is NOT in the word...");
                }
                Console.ResetColor();
            }
            Console.WriteLine($"Congratulations, you won!!! The word was {selectedWord}");
        }

    }
}
