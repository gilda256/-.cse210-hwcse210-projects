using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("Tigan Street", "Yerevan", "Yerevan", "Armenia");
        Address addr2 = new Address("Main Street", "New York", "NY", "USA");

        Customer customer1 = new Customer("David Khachatoriyan", addr1);
        Customer customer2 = new Customer("Don Bernats", addr2);

        Product p1 = new Product("TV", 101, 2000, 1);
        Product p2 = new Product("VR Glasses", 102, 500, 2);
        Product p3 = new Product("PS5", 103, 1000, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);

        Order order2 = new Order(customer2);
        order2.AddProduct(p3);

        Console.WriteLine("Order1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total: {order1.CalculateTotal():N0} \n");

        Console.WriteLine("Order2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total: {order2.CalculateTotal():N0}");
    }
}

    