using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Brayden", "1234 BYU-I Street", "Rexburg", "ID", "USA");
        Order order1 = new Order(customer1);
        order1.AddProduct("Ramen", 6832907, 2, 5);
        order1.AddProduct("Milk", 2608969, 5, 1);

        order1.GetPackingLabel();
        order1.GetShippingLabel();
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice()}");

        Console.WriteLine("");

        Customer customer2 = new Customer("James", "1234 London Drive", "London", "Greater London", "England");
        Order order2 = new Order(customer2);
        order2.AddProduct("Ramen", 6832907, 2, 5);
        order2.AddProduct("Milk", 2608969, 5, 1);
        order2.AddProduct("Acer Laptop", 8806289, 750, 1);

        order2.GetPackingLabel();
        order2.GetShippingLabel();
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice()}");
    }
}