using System;

public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering (string title, string description, string date, string time, Address address, string forecast)
        : base (title, description, date, time, address)
    {
        _weatherForecast = forecast;
    }

    public string GetFullDetails()
    {
        string details = GetStandardDetails();

        details += "The weather for the event will be: " + _weatherForecast;

        return details;
    }
}