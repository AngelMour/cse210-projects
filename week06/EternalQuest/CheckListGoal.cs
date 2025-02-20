using System;
using System.Collections.Generic;
using System.IO;

class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent(ref int score)
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            score += _points;
            if (_amountCompleted == _target)
                score += _bonus;
        }
    }
//overwrite the IsComplete method to return true if the amount completed is equal to the target
    public override bool IsComplete() => _amountCompleted >= _target;
    public override string GetDetailString() => $"[{_amountCompleted}/{_target}] {_shortName} - {_description}";
    public override string GetRepresentation() => $"Checklist,{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
}
