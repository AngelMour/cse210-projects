using System;
using System.Diagnostics;

public class Assignment
{
    private string _studentName = "Samuel Bennett";
    private string _topic = "Multiplication";

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
    public void SetName(string studentName)
    {
        _studentName = studentName;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }
}