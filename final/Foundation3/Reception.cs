using System;

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base (title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public string GetFullDetails()
    {
        string details = GetStandardDetails();

        details += "Please RSVP to: " + _rsvpEmail;

        return details;
    }
}