using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected int _currentPoints = 0;
    protected string _checkBox = "[ ]";

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual void SetIsCompleteToTrue()
    {

    }

    public virtual string GetDetailsString()
    {
        string checkMark = "[ ]";
        
        if (IsComplete())
        {
            checkMark = "[X]";
        }

        return $"{checkMark} {_shortName} - {_description}";
    }

    public abstract string GetStringRepresenatation();
}