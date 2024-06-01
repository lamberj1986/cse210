using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");

        // Creating the product catalog to then be updated with order details as they are created
        Product prod1_apple = new Product("Apple", 1001, 0.55);
        Product prod2_orange = new Product("Orange", 1002, 0.35);
        Product prod3_banana = new Product("Banana", 1003, 0.25);
        Product prod4_iceCream = new Product("Ice Cream", 2001, 6.59);
        Product prod5_frozenPizza = new Product("Frozen Pizza", 2002, 9.59);
        Product prod6_frozenMixedVeggies = new Product("Frozen Mixed Veggies", 2003, 1.79);
        Product prod7_captainCrunch = new Product("Captain Crunch", 3001, 8.59);

        // Creating customer base
        Address address = new Address("123 ABC St", "Aurora", "CO", "USA");
        Customer custOne = new Customer("John Doe", address);

        address = new Address("459 S Tucker St", "Fort Collins", "CO", "USA");
        Customer custTwo = new Customer("Larry Jordan", address);

        address = new Address("9018 Main St", "Sawtry", "East Anglia", "England");
        Customer custThree = new Customer("Charles III", address);


        // Creating the orders
        
        //      Order #1
        //          Item List
        List<Product> order1items = new List<Product>();

        Product order1_item1 = prod2_orange;
        order1_item1.AddQuantity(6);

        Product order1_item2 = prod4_iceCream;
        order1_item2.AddQuantity(2);

        Product order1_item3 = prod7_captainCrunch;
        order1_item3.AddQuantity(4);

        Product order1_item4 = prod3_banana;
        order1_item4.AddQuantity(10);

        order1items.Add(order1_item1);
        order1items.Add(order1_item2);
        order1items.Add(order1_item3);
        order1items.Add(order1_item4);

        //          Creating the order
        Order orderOne = new Order(custOne, order1items);

        //      Order #2
        //          Item List
        List<Product> order2items = new List<Product>();

        Product order2_item1 = prod1_apple;
        order2_item1.AddQuantity(8);

        Product order2_item2 = prod5_frozenPizza;
        order2_item2.AddQuantity(3);

        // Product order2_item3 = prod2_orange;
        // order2_item3.AddQuantity(3);

        Product order2_item4 = prod6_frozenMixedVeggies;
        order2_item4.AddQuantity(4);

        order2items.Add(order2_item1);
        order2items.Add(order2_item2);
        // order2items.Add(order2_item3);
        // For some reason line 73 doesn't get the quantity right and that throws off the price calculation.
        order2items.Add(order2_item4);

        //          Creating the order
        Order orderTwo = new Order(custTwo, order2items);

        //      Order #3
        //          Item List
        List<Product> order3items = new List<Product>();

        Product order3_item1 = prod2_orange;
        order3_item1.AddQuantity(6);

        Product order3_item2 = prod4_iceCream;
        order3_item2.AddQuantity(2);

        Product order3_item3 = prod7_captainCrunch;
        order3_item3.AddQuantity(4);

        Product order3_item4 = prod3_banana;
        order3_item4.AddQuantity(10);

        order3items.Add(order3_item1);
        order3items.Add(order3_item2);
        order3items.Add(order3_item3);
        order3items.Add(order3_item4);

        //          Creating the order
        Order orderThree = new Order(custThree, order3items);

        // Displaying the orders
        Console.WriteLine("Order 1 Details");
        Console.WriteLine("\n"+orderOne.GeneratePackingLabel());
        Console.WriteLine("\n"+orderOne.GenerateShippingLabel());
        Console.WriteLine("\n Order Total Cost: $"+orderOne.CaclulateTotalCost());

        Console.WriteLine("\nOrder 2 Details");
        Console.WriteLine("\n"+orderTwo.GeneratePackingLabel());
        Console.WriteLine("\n"+orderTwo.GenerateShippingLabel());
        Console.WriteLine("\n Order Total Cost: $"+orderTwo.CaclulateTotalCost());

        Console.WriteLine("\nOrder 3 Details");
        Console.WriteLine("\n"+orderThree.GeneratePackingLabel());
        Console.WriteLine("\n"+orderThree.GenerateShippingLabel());
        Console.WriteLine("\n Order Total Cost: $"+orderThree.CaclulateTotalCost());
    }
}