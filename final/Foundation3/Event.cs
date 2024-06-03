using System.ComponentModel;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        string standard = "Title: " + _title + "\n";
        standard += "Description: " + _description + "\n";
        standard += _date + " | " + _time + "\n";

        string address = _address.GetFullAddress() + "\n";
        standard += address;

        return standard;
    }

    public string GetShortDescription()
    {
        string shortDesc = "Title: " + _title + "\n";

        shortDesc += _date + "\n";

        return shortDesc;
    }
}