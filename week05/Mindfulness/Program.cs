using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


class Program
{
    static void Main()
    {
        //like journal menu
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exercising Activity");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            Activity activity = null;

            if (choice == "1")
                activity = new BreathingActivity();
            else if (choice == "2")
                activity = new ReflectingActivity();
            else if (choice == "3")
                activity = new ListingActivity();
            else if (choice == "4")
                activity = new ExercisingActivity();
            else if (choice == "5")
                break;
            else
                Console.WriteLine("Invalid choice. Try again.");

            if (activity != null)
                ((dynamic)activity).Run();
        }
    }
}


/*
class Program
{
    static void Main(string[] args)
    {
        Activity activity1 = new Activity("Mindfulness", "Meditation");
    }
    private void DisplayMenu()
    {
        Console.WriteLine("Mindfulness Menu");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");
        Console.Write("Enter your choice: ");
    }

    public void Menu()
    {
        bool running = true;

        while (running)
        {
            DisplayMenu();
            string choice = Console.ReadLine();
COULD BE BETTER
            switch (choice)
            {
                case "1":
                    BreathingActivity();
                    break;
                case "2":
                    ReflectionActivity();
                    break;
                case "3":
                    ListingActivity();
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

}*/


