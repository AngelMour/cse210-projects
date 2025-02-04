using System;

public class WritingAssignment : Assignment
{
    private string _title = "";
    private string _author = "";

    public WritingAssignment(string studentName, string topic, string title, string author) : base(studentName, topic)
    {
        _title = title;
        _author = author;
    }

    /*public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }*/
    public string GetWritingInformation()
    {
        return $"{_title} by {_author}";
    }
}