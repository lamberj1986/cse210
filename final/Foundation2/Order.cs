using System;

public class Order
{
    private Customer _customer = new();
    private List<Product> _products = new();
    private decimal totalPrice;
    private decimal itemPrice;

    public Order()
    {
        // Allowing for a blank variable definition
    }

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public decimal CaclulateTotalCost()
    {
        foreach (Product product in _products)
        {
            itemPrice = product.CalculatePrice();

            totalPrice += itemPrice;
        }

        return totalPrice;
    }

    public string GeneratePackingLabel()
    {
        string packingList;

        packingList = _customer.GetCustomerName();

        foreach (Product product in _products)
        {
            packingList += "\n   -" + product.GetOrderLineItems();
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