using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer()
    {
        // No need to do anything here
    }
    
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.IsUSAAddress();
    }

    public string GetCustomerName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetFullAddress();
    }
}