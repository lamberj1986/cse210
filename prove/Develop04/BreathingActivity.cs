using System;

public class Breathing : Activity
{
    // private int _breathDuration = 0;

    public Breathing(int duration) 
        : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", duration)
    {
        // Removing this as I changed the base class duration to protected
        // _breathDuration = duration;
    }
    
    public void Run()
    {
        DisplayStartingMessage();

        // DateTime currentTime = DateTime.Now;
        // DateTime stopTime = currentTime.AddSeconds(_duration);

        int seconds = 0;
        bool overTime = true;
        
        while (overTime) // Changed this from <= to < to see if this will stop on time.
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Breath in...");
            ShowCountDown(2);
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Breath out...");
            ShowCountDown(3);

            Console.Clear();
            Thread.Sleep(500);

            // currentTime = DateTime.Now;

            seconds += 5000;
            overTime = seconds < _duration;
        }

        Console.Clear();
        ShowSpinner(10);

        DisplayEndingMessage();
    }
}