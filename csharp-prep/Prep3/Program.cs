using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        // Console.WriteLine("What is the magic nubmer?");
        // string magicNumberStr = Console.ReadLine();
        // int magicNumber = int.Parse(magicNumberStr);

        int guess;
        string contPlay = "yes";

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            int guessCount = 0;

            do
            {
                Console.WriteLine("What is your guess?");
                string guessStr = Console.ReadLine();
                guess = int.Parse(guessStr);
                guessCount += 1;

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                    Console.WriteLine($"You have guessed {guessCount} time(s).");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                    Console.WriteLine($"You have guessed {guessCount} time(s).");
                }
                else
                {
                    Console.WriteLine("Correct.");
                    Console.WriteLine($"It took you {guessCount} times to guess the magic number.");
                    
                    Console.WriteLine("Would you like to play again?");
                    contPlay = Console.ReadLine();
                }
            } while (guess != magicNumber);
        } while (contPlay == "yes");
    }
}