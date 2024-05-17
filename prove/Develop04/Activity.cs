using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration * 1000; // Adjusting the duration to account for the system using milliseconds
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Current Activity: {_name}\n\n{_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n\nCongradulations on completing this activity! You are one step closer to being more mindful.\nLet's keep working on this journey.");
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;

        int freezeTime = 500; // Adding this to be able to update the animation time without having to change multple lines

        while (currentTime < stopTime)
        {
            Console.Write("-");
            Thread.Sleep(freezeTime);

            Console.Write("\b \b");
            Console.Write("\\");

            Thread.Sleep(freezeTime);

            Console.Write("\b \b");
            Console.Write("-");

            Thread.Sleep(freezeTime);

            Console.Write("\b \b");
            Console.Write("/");

            Thread.Sleep(freezeTime);

            Console.Write("\b \b");
            Console.Write("-");

            Thread.Sleep(freezeTime);

            currentTime = DateTime.Now;
        }
    }

    public void ShowCountDown(int seconds)
    {
        int timeLeft = seconds;
        
        Console.Write($"There are this many seconds left: {timeLeft}");

        while (timeLeft > 0)
        {
            Thread.Sleep(1000);
            timeLeft--;
            Console.Write("\b \b");
            Console.Write(timeLeft);
        }

        Console.Clear();
        Console.WriteLine("Time's up!");
    }
}