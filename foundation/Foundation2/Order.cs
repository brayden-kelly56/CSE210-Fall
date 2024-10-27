using System.Numerics;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public int CalculateTotalPrice()
    {
        int total = 0;
        foreach (Product product in _products)
        {
            total += product.GetPrice() * product.GetQuantity();
        }

        if (_customer.IsInUSA() == true)
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public void GetPackingLabel()
    {
        Console.WriteLine("Packing Label:");
        foreach(Product product in _products)
        {
            Console.WriteLine($"{product.GetProduct()}");
            Console.WriteLine($"{product.GetProductID()}");
        }
        Console.WriteLine("");
    }

    public void GetShippingLabel()
    {
        string name = _customer.GetCustomer();
        string address = _customer.GetAddress();

        Console.WriteLine("Shipping Label:");
        Console.WriteLine($"Customer Name: {name}");
        Console.WriteLine($"Deliver to: {address}");

    }

    public void AddProduct(string name, int id, int price, int quantity)
    {
        _products.Add(new Product(name, id, price, quantity));
    }
}