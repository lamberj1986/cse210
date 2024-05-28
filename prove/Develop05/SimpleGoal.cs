using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : 
        base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _isComplete = false;
        _points = points;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        _currentPoints += _points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresenatation()
    {   
        return $"SimpleGoal:|{_shortName}|{_description}|{_isComplete}";
    }

}