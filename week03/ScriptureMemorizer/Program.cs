using System;
using System.Collections.Generic;
using System.Linq;

class Program
    {
        static void Main(string[] args)
        {   // clear the console and display the welcome message, per sample in assigment
            Console.Clear();
            Console.WriteLine("Welcome to the Scripture Memorization exercise!");

            // Example scripture, may change for the stretch fetures if anogh time
            var reference = new Reference("Proverbs", 3, 5, 6);
            var scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding.");

            while (true)
            // while loop to keep the program running
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
                // display the text and ask the user to press enter or type quit
                string input = Console.ReadLine()?.Trim().ToLower();
                // read the input from the user
                if (input == "quit")
                {
                    Console.WriteLine("Chau!");
                    break;
                }
                // if the user types quit, the program will exit
                scripture.HideRandomWords(3);
                // hide 3 random words
                if (scripture.AreAllWordsHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.WriteLine("\nGood job!");
                    break;
                }
            }
        }
    }