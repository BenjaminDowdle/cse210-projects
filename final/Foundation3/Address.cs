public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;

    public Address(string street, string city, string stateProvince)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
    }

    public string Street
    {
        get { return _street; }
    }

    public string City
    {
        get { return _city; }
    }

    public string StateProvince
    {
        get { return _stateProvince; }
    }

    public string DisplayAddress()
    {
        return $"{_street} {_city}, {_stateProvince}";
    }
}