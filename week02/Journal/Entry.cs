using System;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string promptText, string entryText)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        _promptText = promptText;
        _entryText = entryText;
    }

    public object Date { get; internal set; }
    public object PromptText { get; internal set; }
    public object EntryText { get; internal set; }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine(new string('-', 30));
    }
}
