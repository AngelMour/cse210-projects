using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"{_name} Activity");
        Console.WriteLine(_description);
        Console.Write("Enter the desire duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Great job! You have completed the activity.");
        Console.WriteLine($"Activity: {_name}, Duration: {_duration} seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
            //Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}
/*
public class Activity;
{
    private string _name;
    private string _description;
    private string _duration;   

    public Activity(string name, string description, string duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public DisplayStartingMessage() : void
    {
        Console.WriteLine("Starting activity: " + _name);
    }

    public DisplayEndingMessage() : void
    {
        Console.WriteLine("Ending activity: " + _name);
    }

    ShowSpinner(seconds: int) : void
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    ShowCountdown(seconds: int) : void
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine("Go!");
    }
/*
    public string GetActivityInfo()
    {
        return $"{_name} ({_duration})";
    }

    public string GetActivityDescription()
    {
        return $"{_description}";
    }

    public string GetActivityDuration()
    {
        return $"{_duration}";
    }

    public void DisplayActivity()
    {
        Console.WriteLine($"{_name} ({_duration})");
        Console.WriteLine($"{_description}");
    }*/
