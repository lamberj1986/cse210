using System;

public class Listing : Activity
{
    private int _count = 0;
    private int _duration;
    private List<String> _prompts = new List<string>
    {
        "Who are the people in your life that you appreciate?",
        "Who are your personal heroes?",
        "Who are people that you have helped this week?",
        "What are some attributes that you admire in others?",
        "What are some attributes about yourselfe that you love?",
        "What are some of your personal strengths?",
        "When have you felt the influence of the Holy Ghost recently?",
        "When was the last time you felt a deep sense of gratitude?"
    };
    private List<string> _responses = new List<string>
    {};

    public Listing(int duration) 
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration)
    {
        _duration = duration;
    }

    public void Run()
    {
        DisplayStartingMessage();

        GetRandomPrompt();

        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> _tempResponses = new List<string>
        {};

        _tempResponses = GetListFromUser();

        _count = _tempResponses.Count;
        
        Console.Clear();

        ShowSpinner(10);

        Console.WriteLine();
        Console.WriteLine($"You were able to enter {_count} replies. Well Done!");
        Console.WriteLine();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rando = new Random();
        int promptIndex = rando.Next(0, _prompts.Count);

        Console.WriteLine();
        Console.WriteLine("Please provide as many responses as you can to the following prompt:");
        Console.WriteLine($"|  {_prompts[promptIndex]}   |");
        Console.WriteLine();
    }

    public List<string> GetListFromUser()
    {
        DateTime currentTime = DateTime.Now;
        DateTime stopTime = currentTime.AddSeconds(_duration);
        
        while (currentTime <= stopTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            _responses.Add(input);

            currentTime = DateTime.Now;
        }

        return _responses;
    }
}