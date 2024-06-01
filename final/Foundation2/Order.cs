using System;

public class Order
{
    private Customer _customer = new();
    private List<Product> _products = new();
    private double totalPrice;
    private double itemPrice;

    public Order()
    {
        // Allowing for a blank constructor
    }

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double CaclulateTotalCost()
    {
        double shippingCost;

        foreach (Product product in _products)
        {
            itemPrice = product.CalculatePrice();

            totalPrice += itemPrice;
        }

        if (_customer.LivesInUSA())
        {
            shippingCost = 5.00;
        }
        else
        {
            shippingCost = 35.00;
        }

        totalPrice += shippingCost;

        return totalPrice;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GeneratePackingLabel()
    {
        string packingList;

        packingList = _customer.GetCustomerName();

        foreach (Product product in _products)
        {
            packingList += "\n   - " + product.GetOrderLineItems();
        }

        return packingList;
    }

    public string GenerateShippingLabel()
    {
        string shippingLabel;

        shippingLabel = _customer.GetCustomerName();

        shippingLabel += "\n" + _customer.GetAddress();

        return shippingLabel;
    }
}