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

    public override void RecordEvent(ref int score)
    {
        if (!_isComplete)
        {
            _isComplete = true;
            score += _points;
        }
    }

    public override bool IsComplete() => _isComplete;
    public override string GetDetailString() => $"[{(_isComplete ? "X" : " ")}] {_shortName} - {_description}";
    public override string GetRepresentation() => $"Simple,{_shortName},{_description},{_points},{_isComplete}";
}