using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _isComplete = false;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : 
        base (name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            _isComplete = true;
        }

        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString();
    }

    public override string GetStringRepresenatation()
    {
        throw new NotImplementedException();
    }

    public void SetCompletedCount()
    {
        _amountCompleted++;
    }

    public int GetCount()
    {
        return _amountCompleted;
    }
}