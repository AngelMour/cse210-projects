using System;
using System.Collections.Generic;

//Class Video:

//attributes:
//_title: string
//_author: string
//_length: double (for seconds)
//_comments: List<Comment>

//methods;
//NumberComments(): int. (List.Count())
//DisplayComment(): void
//AddComment(Comment): void
class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Length { get; set; } // in seconds
    private List<Comment> _comments;

    public Video(string title, string author, double length)
    {
        Title = title;
        Author = author;
        Length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int NumberComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nLength: {Length} seconds\nNumber of Comments: {NumberComments()}\n");
        Console.WriteLine("Comments:");
        foreach (var comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine("\n-----------------------------\n");
    }
}