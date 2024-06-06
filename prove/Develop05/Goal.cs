using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected bool _isComplete;
    protected int _currentPoints = 0;
    protected string _checkBox = "[ ]";

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _isComplete = false;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual void SetIsCompleteToTrue()
    {
        _isComplete = true;
    }

    public virtual string GetDetailsString()
    {
        string checkMark = "[ ]";
        
        if (_isComplete)
        {
            checkMark = "[X]";
        }

        return $"{checkMark} {_shortName} - {_description}";
    }

    public virtual int GetPointTotal()
    {
        return _currentPoints;
    }

    public abstract string GetStringRepresenatation();
}