using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool IsUSAAddress()
    {
        // Check to see if country is USA
        bool isUSA = _country.ToUpper() == "USA";
        
        // Catch to see if the country was entered as US
        if (!isUSA)
        {
            isUSA = _country.ToUpper() == "US";
        }

        return isUSA;
    }

    public string GetFullAddress()
    {
        string fullAddress = _street + "\n" + _city + ", " + _stateProvince + " " + _country.ToUpper();

        return fullAddress;
    }
}