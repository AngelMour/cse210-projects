using System;
using System.Collections.Generic;


//Class Comment:

//attributes:
//_name: string
//_text: string

//methods;
//Display Comment(): void


// Here on the Comment class is to store user comments on videos
class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{Name}: {Text}");
    }
}