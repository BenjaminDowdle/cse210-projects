using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain == "yes")
        {



            Random randomGen = new Random();
            int magicNumber = randomGen.Next(1, 101);

            int guess = -1;

            while (guess != magicNumber)
            {
                Console.WriteLine("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

            }
            Console.WriteLine("Would you like to play again? ");
            playAgain = Console.ReadLine();
        }
    }
}