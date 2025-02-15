using System;
using System.Collections.Generic;
using System.IO;

class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
//overwrite the RecordEvent method to add the points to the score if the goal has not been completed
    public override void RecordEvent(ref int score)
    {
        if (!_isComplete)
        {
            _isComplete = true;
            score += _points;
        }
    }
//overwrite the IsComplete method to return the value of the _isComplete field
    public override bool IsComplete() => _isComplete;
    public override string GetDetailString() => $"[{(_isComplete ? "X" : " ")}] {_shortName} - {_description}";
    public override string GetRepresentation() => $"Simple,{_shortName},{_description},{_points},{_isComplete}";
}