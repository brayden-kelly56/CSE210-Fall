public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProv;
    private string _country;

    public Address(string street, string city, string stateOrProv, string country)
    {
        _street = street;
        _city = city;
        _stateOrProv = stateOrProv;
        _country = country;
    }

    public bool IsUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetAddress()
    {
        string street = _street;
        string city = _city;
        string stateOrProv = _stateOrProv;
        string country = _country;

        string address = $"{street}, {city}, {stateOrProv}, {country}";
        return address;
    }
}