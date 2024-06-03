using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base (title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetFullDetails()
    {
        string details = GetStandardDetails();

        details += "Speaker: " + _speaker + "\n";
        details += "Capacity: " + _capacity + " max";

        return details;
    }
}