using System;

public class Reflecting : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you faced a truly difficult task.",
        "Think of a moment when you confronted and addressed an injustice or unfairness.",
        "Think ot a memory when you were generous with another and shared your knowledge/expertise with somebody else.",
        "Think of an occasion when you overcame a major obstacle through perserverance.",
        "Think of a time when you took a big risk and it came out for the best.",
        "Think of a time when you prioritized the needs of another above your own.",
        "Think of a time when you stood up for someone else.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };

    private List<string> _questions = new List<string>
    {
        "What part of this experience resonated with you the most?",
        "How did you feel after doing this?",
        "What were the steps that you took to accomplish this? Are they repeatable?",
        "What self-discoveries did you make through this event?",
        "What are some broader applications or lessons can you take from this experience?",
        "How can you try to do this more often in your life?",
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "What mad this time different than other times when you were not as successful?",
        "What is your favorite thing abou this eperience?",
        "What could you learn from this experience that applies to other situations?",
    };

    // Removing this as the Activity base class is now protected
    // private int _duration;
    private int promptIndex;
    private int quesIndex;

    public Reflecting(int duration) 
        : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration)
    {
        // This is no longer needed with the base duration now being protected
        // _duration = duration;
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        DisplayPrompt();

        DisplayQuestions();

        Console.Clear();
        ShowSpinner(10);

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rando = new Random();
        promptIndex = rando.Next(0, _prompts.Count);
    }

    public void GetRandomQuestion()
    {
        Random rando = new Random();
        quesIndex = rando.Next(0, _questions.Count);
    }

    public void DisplayPrompt()
    {
        GetRandomPrompt();

        Console.WriteLine();
        Console.WriteLine("Please consider the following prompt:");
        Console.WriteLine($"|  {_prompts[promptIndex]}   |");
        Console.WriteLine();
        Console.WriteLine("When you are ready to proceed, press enter to continue.");
        Console.ReadLine();
        Console.Clear();
    }

    public void DisplayQuestions()
    {
        GetRandomQuestion();

        DateTime currentTime = DateTime.Now;
        DateTime stopTime = currentTime.AddSeconds(_duration);
        
        while (currentTime <= stopTime)
        {
            Console.WriteLine();
            Console.WriteLine("Please provide as many responses as you can to the following prompt:");
            Console.WriteLine($"|  {_questions[quesIndex]}   |");
            Console.WriteLine();

            ShowSpinner(5);

            GetRandomQuestion();

            currentTime = DateTime.Now;
        }
    }
}