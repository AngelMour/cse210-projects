using System;

class Program
{
    static void Main(string[] args)
    {
        
        WelcomeMessage();

        string name = GetName();
        int number = GetNumber();

        int squaredNumber = SquareNumber(number);

        DisplayResults(name, number, squaredNumber);
    }

    static void WelcomeMessage()
    {
      
        Console.WriteLine("Welcome to the program!");
    }

    static string GetName()
    {

        Console.Write("Please enter your name? ");
        string name = Console.ReadLine();

        return name;   
    }

    static int GetNumber()
    {

        Console.Write("Please enter your favorite number? ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;

        return squaredNumber;
    }

    static void DisplayResults(string name, int number, int squaredNumber)
    {
        Console.WriteLine("Hello, " + name + "!");
        Console.WriteLine("Your favorite number is " + number);
        Console.WriteLine("The square of your favorite number is " + squaredNumber);
    }
}