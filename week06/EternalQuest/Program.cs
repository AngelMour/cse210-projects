using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
//add a Start method to display the menu
    public void Start()
    {
        while (true)
        {
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Events");
            Console.WriteLine("6. Quit");
//add a switch statement to handle the user's choice
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                case "6": return;
            }
        }
    }
//add a method to create a goal
    private void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());
//add a switch statement to create the appropriate goal based on the user's choice
        switch (choice)
        {
            case "1": _goals.Add(new SimpleGoal(name, description, points)); break;
            case "2": _goals.Add(new EternalGoal(name, description, points)); break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new CheckListGoal(name, description, points, target, bonus));
                break;
        }
    }

    private void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailString());
        }
    }
//add a method to record an event
    private void RecordEvent()
    {
        Console.WriteLine("Select goal to record event:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailString()}");
        }

        int index = int.Parse(Console.ReadLine()) - 1;
        _goals[index].RecordEvent(ref _score);
        Console.WriteLine("Congratulations!! ");
    }
//add a method to save the goals to a file
    private void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetRepresentation());
            }
        }
    }
//add a method to load the goals from the file
    private void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                _score = int.Parse(reader.ReadLine());
                while (!reader.EndOfStream)
                {
                    string[] parts = reader.ReadLine().Split(',');
                    if (parts[0] == "Simple") _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
                    else if (parts[0] == "Eternal") _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    else if (parts[0] == "Checklist") _goals.Add(new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])));
                }
            }
        }
    }

    static void Main()
    {
        Program program = new Program();
        program.Start();
    }
}