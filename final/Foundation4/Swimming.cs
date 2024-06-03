using System;

public class Swimming : Activity
{
    private int _laps;
    private double _distance;

    public Swimming(string date, int duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
        _distance = _laps * 50 / 1000;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _duration) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetSummary()
    {
        return _date + " Swimming (" + _duration + "min) - Distance " + _distance + "km, Speed: " + GetSpeed() + "kph, Pace: " + GetPace() + "min per km";
    }
}