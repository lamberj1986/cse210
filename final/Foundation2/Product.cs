using System;

public class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string name, int productId, double price)
    {
        // Allowing for a constructor to be built to allow a catalog of products to be built
        _name = name;
        _productId = productId;
        _price = price;
    }

    public Product(string name, int productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public void AddQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public double CalculatePrice()
    {
        return _price * _quantity;
    }

    public string GetOrderLineItems()
    {
        return _productId + ": " + _name + " (" + _quantity + ")";
    }
}