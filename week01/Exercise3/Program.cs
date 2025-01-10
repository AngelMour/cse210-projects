using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        
        int guess = -1;

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();
            guess = int.Parse(input);

            if (guess < number)
            {
                Console.WriteLine("Too low!");
            }
            else if (guess > number)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}