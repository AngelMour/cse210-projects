using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class ExercisingActivity : Activity
{
    private List<string> _prompts2 = new List<string>
    {
        "Going for walk.",
        "Take your dog for a walk.",
        "Take a book to read at a park.",
        "Bird watching."
        "Take your journal on a walk."
    };

    private List<string> _questions2 = new List<string>
    {
        "How did this activity impacted you?",
        "Have you ever done anything like this before?",
        "Was it hard to do this activity? if so how can I make it more enjoyable next time?",
        "How did you feel when you completed the activity?",
    };

    public ExercisingActivity() : base("Exercising", "This activity helps you create a connection between mind a body by convining meditation with fiscical activity .") { }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(3);
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(5);
            elapsed += 5;
        }
        DisplayEndingMessage();
    }

    private string GetRandomPrompt() => _prompts2[new Random().Next(_prompts2.Count)];
    private string GetRandomQuestion() => _questions2[new Random().Next(_questions2.Count)];
}
