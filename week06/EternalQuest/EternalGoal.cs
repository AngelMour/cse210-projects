using System;
using System.Collections.Generic;
using System.IO;



class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) {}

    public override void RecordEvent(ref int score)
    {
        score += _points;
    }

    public override bool IsComplete() => false;
    public override string GetDetailString() => $"[∞] {_shortName} - {_description}";
    public override string GetRepresentation() => $"Eternal,{_shortName},{_description},{_points}";
}