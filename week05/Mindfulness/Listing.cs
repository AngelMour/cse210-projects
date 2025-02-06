using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity helps you reflect on the good things in your life by listing them.") { }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        ShowCountDown(5);
        Console.WriteLine("Start listing items:");
        List<string> items = new List<string>();
        int elapsed = 0;
        while (elapsed < _duration)
        {
            items.Add(Console.ReadLine());
            elapsed += 3;
        }
        Console.WriteLine($"You listed {items.Count} items.");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt() => _prompts[new Random().Next(_prompts.Count)];
}
