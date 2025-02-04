using System;
using System.Collections.Generic;

/*
Class Program
Create at least 2 order with 2-3 products each
 
Attributes:
 
Methods:
GetPackingLabel():
 
GetShippingLabel():
 
GetTotalPrice(): (call from Order class)
*/
class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Oklahoma City", "OK", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("456 Elm St", "Tulsa", "OK", "USA");
        Customer customer2 = new Customer("Jane Smith", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", 101, 1, 999.99));
        order1.AddProduct(new Product("Mouse", 102, 2, 25.50));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", 103, 1, 49.99));
        order2.AddProduct(new Product("Monitor", 104, 1, 199.99));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.TotalPrice());
        Console.WriteLine();
        
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.TotalPrice());
    }
}
