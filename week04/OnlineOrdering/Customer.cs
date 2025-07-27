public class Customer
{ 
    // MEMBER VARIABLES
    private string _name;
    private Address _address;

    // CONSTRUCTOR
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // METHODS
    public bool IsInUSA() // Check if the customer is in the USA
    {
        return _address.InUSA();
    }

    // GETTERS AND SETTERS
    public string GetCustomerInfo() // Get customer information
    {
        return $" {_name}\n{_address.GetFullAddress()}";
    }
    public string GetName() // Retrieve customer name
    {
        return _name;
    }
    public Address GetAddress() // Retrieve customer address
    {
        return _address;
    }
    public void UpdateAddress(Address newAddress) // Update customer's address
    {
        _address = newAddress;
    }
    public void UpdateName(string newName) // Update customer's name
    {
        _name = newName;
    }
}