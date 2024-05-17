using System;

public class BreatingActivity : Activity
{
    public BreathingActivity(int duration) 
        : base(_name, _description, _duration)
    {
        _name = "Breathing Activity";
        _description = "TBD";
        _duration = duration;
    }


}