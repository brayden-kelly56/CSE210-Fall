using System.Numerics;

public class Product
{
    private string _name;
    private int _id;
    private int _price;
    private int _quantity;

    public Product(string name, int id, int price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public int GetPrice()
    {
        int price = _price;
        return price;
    }

    public int GetQuantity()
    {
        int quantity = _quantity;
        return quantity;
    }

    public string GetProduct()
    {
        string product = _name;
        return product;
    }

    public int GetProductID()
    {
        int id = _id;
        return id;
    }
}