using System;

class Program
{
    static void Main(string[] args)
    {
        bool finish = false;
        Random num = new Random();
        int magicNumber = num.Next(1,100);
        while (finish == false)
        {
            Console.WriteLine("What is your guess? ");
            string guessInput = Console.ReadLine();
            int guess = int.Parse(guessInput);
            if (guess == magicNumber)
            {
                finish = true;
                Console.WriteLine("You guessed it!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
        }
    }
}