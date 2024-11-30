using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<Order> _orders = new List<Order>();

        _orders.Add(new Order(
            1,
            new List<Product> { new Product("Xbox Series X", "10234", 499.99f, 1), new Product("Xbox Controller", "00332002", 49.99f, 4) },
            new Customer("John Jacobs", new Address("986 Gilbert Street", "New York City", "NY", "USA"))
        ));

        _orders.Add(new Order(
            2,
            new List<Product> { new Product("Xbox Series S", "10235", 359.99f, 2), new Product("Xbox Controller", "00332002", 49.99f, 2), new Product("Halo Infinite", "83212", 69.99f, 2) },
            new Customer("Tyler Hatton", new Address("237 Common Court", "Lexington", "KY", "United States"))
        ));

        foreach (Order order in _orders)
        {
            order.DisplayAllOrderInfo();
        }
    }
}