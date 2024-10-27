public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, string street, string city, string stateOrProv, string country)
    {
        _name = name;
        _address = new Address(street, city, stateOrProv, country);
    }

    public bool IsInUSA()
    {
        return _address.IsUSA();
    }

    public string GetCustomer()
    {
        string customer = _name;
        return customer;
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }
}