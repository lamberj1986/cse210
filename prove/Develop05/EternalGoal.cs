using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : 
        base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _isComplete = false;
        _points = points;
    }

    public override void RecordEvent()
    {
        _currentPoints += _points;
    }

    public override bool IsComplete()
    {
        _isComplete = false;

        return _isComplete;
    }

    public override string GetStringRepresenatation()
    {
        return $"EternalGoal:|{_shortName}|{_description}|{_points}";
    }
}