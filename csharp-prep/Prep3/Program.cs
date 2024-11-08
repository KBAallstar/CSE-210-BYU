using System;

class Program
{
    static void Main(string[] args)
    {
        // For Parts 1 and 2, where the user specified the number...
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        
        int maxMagicNumber = 100;
        Random randomGenerator = new Random();

        string keepGoing = "yes";

        do {
            int magicNumber = randomGenerator.Next(1, (maxMagicNumber + 1));

            int guess = -1;
            int guessCount = 0;

            while (guess != magicNumber)
            {
                Console.Write($"Guess the magic number (1-{maxMagicNumber})? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    guessCount++;
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    guessCount++;
                    Console.WriteLine("Lower");
                }
                else
                {
                    guessCount++;
                    Console.WriteLine("You guessed the magic number!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }

            }

            Console.Write("Do you want to play again (yes/no)? ");
            keepGoing = Console.ReadLine();
        } while (keepGoing == "yes");
    }
}