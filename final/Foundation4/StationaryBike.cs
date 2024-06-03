using System;

public class StationaryBike : Activity
{
    private double _speed;

    public StationaryBike(string date, int duration, double speed)
        : base (date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = _speed * _duration;

        return distance;   
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return _date + " Biking (" + _duration + "min) - Distance " + GetDistance() + "km, Speed: " + GetSpeed() + "kph, Pace: " + GetPace() + "min per km";
    }
}