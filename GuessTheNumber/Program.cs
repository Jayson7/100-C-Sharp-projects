using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the Number Game!\n");
            Console.WriteLine("I'm thinking of a number between 1 and 100.\n");

            Random random = new Random();
            int targetNumber = random.Next(1, 101);
            int guess = 0;
            int attempts = 0;

            while (guess != targetNumber)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                attempts++;

                if (guess < targetNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"\nCongratulations! You guessed it in {attempts} attempt(s)!");
                }
            }

            Console.ReadKey();
        }
    }
}
