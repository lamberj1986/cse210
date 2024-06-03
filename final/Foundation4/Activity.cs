using System;

public class Activity
{
    protected string _date;
    protected int _duration;

    public Activity()
    {

    }

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return "No activity recorded";
    }


}