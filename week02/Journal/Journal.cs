using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine($"{entry.Date}|{entry.PromptText}|{entry.EntryText}");
                }
            }
            Console.WriteLine($"Journal saved to {file}.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error saving journal: {e.Message}");
        }
    }

    public void LoadFromFile(string file)
    {
        try
        {
            _entries.Clear();
            foreach (var line in File.ReadLines(file))
            {
                var parts = line.Split('|');
                if (parts.Length == 3)
                {
                    _entries.Add(new Entry(parts[1], parts[2]));
                }
            }
            Console.WriteLine($"Journal loaded from {file}.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error loading journal: {e.Message}");
        }
    }
}
