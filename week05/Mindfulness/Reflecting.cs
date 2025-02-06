using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base("Reflecting", "This activity helps you reflect on moments of strength and resilience.") { }

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

    private string GetRandomPrompt() => _prompts[new Random().Next(_prompts.Count)];
    private string GetRandomQuestion() => _questions[new Random().Next(_questions.Count)];
}
