using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : 
        base (name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _isComplete = false;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int countComplete) : 
        base (name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _isComplete = false;
        _bonus = bonus;
        _amountCompleted = countComplete;
    }

    public override void RecordEvent()
    {
        _currentPoints += _points;
        
        SetCompletedCount();

        if (_amountCompleted == _target)
        {
            _isComplete = true;
            _currentPoints += _bonus;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string toReturn = $"[ ] {_shortName} - {_description}. {_amountCompleted} / {_target} completed";
        
        if (_isComplete)
        {
            toReturn = $"[X] {_shortName} - {_description}. {_amountCompleted} / {_target} completed. All done!";
        }
        
        return toReturn;
    }

    public override string GetStringRepresenatation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}";
    }

    public void SetCompletedCount()
    {
        _amountCompleted++;
    }

    public int GetCount()
    {
        return _amountCompleted;
    }

    public override int GetPointTotal()
    {
        return _currentPoints;
    }
}