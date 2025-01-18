using System;

public class Program
{
    private Journal _journal;
    private PromptGenerator _promptsGenerator;

    public Program()
    {
        _journal = new Journal();
        _promptsGenerator = new PromptGenerator();
    }

    private void DisplayMenu()
    {
        Console.WriteLine("Journal Menu:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display journal");
        Console.WriteLine("3. Save journal to file");
        Console.WriteLine("4. Load journal from file");
        Console.WriteLine("5. Exit");
        Console.Write("Enter your choice: ");
    }

    private void WriteEntry()
    {
        string prompt = _promptsGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        Entry entry = new Entry(prompt, response);
        _journal.AddEntry(entry);
    }

    private void DisplayJournal()
    {
        _journal.DisplayAll();
    }

    private void SaveJournal()
    {
        Console.Write("Enter filename to save journal: ");
        string filename = Console.ReadLine();
        _journal.SaveToFile(filename);
    }

    private void LoadJournal()
    {
        Console.Write("Enter filename to load journal: ");
        string filename = Console.ReadLine();
        _journal.LoadFromFile(filename);
    }

    public void Run()
    {
        bool running = true;

        while (running)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteEntry();
                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    SaveJournal();
                    break;
                case "4":
                    LoadJournal();
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
}