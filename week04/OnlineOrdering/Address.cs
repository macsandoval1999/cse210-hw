public class Address
{
    // MEMBER VARIABLES
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    // CONSTRUCTOR
    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // METHODS
    public string GetFullAddress() // Retrieve full address as a formatted string
    {
        return $" {_street},\n {_city} {_stateProvince}, {_country}";
    }
    public bool InUSA() // Check if the address is in the USA
    {
        string country = _country.ToLower();
        if (country == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    // GETTERS AND SETTERS
    public string GetStreet() // Retrieve street
    {
        return _street;
    }
    public void SetStreet(string street) // Set street
    {
        _street = street;
    }
    public string GetCity() // Retrieve city
    {
        return _city;
    }
    public void SetCity(string city) // Set city
    {
        _city = city;
    }
    public string GetStateProvince() // Retrieve state or province
    {
        return _stateProvince;
    }
    public void SetStateProvince(string stateProvince) // Set state or province
    {
        _stateProvince = stateProvince;
    }
    public string GetCountry() // Retrieve country
    {
        return _country;
    }
    public void SetCountry(string country) // Set country
    {
        _country = country;
    }
}