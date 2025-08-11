public abstract class Employee // Abstract because it has member variables and doesnt exist to just define methods to be overwritten
{
    // -----MEMBER VARIABLES-----
    private string _name;
    private string _id;
    private string _address;
    private string _birthday;
    // -----CONSTRUCTORS-----
    public Employee(string name, string id, string address, string birthday)
    {
        _name = name;
        _id = id;
        _address = address;
        _birthday = birthday;
    }
    // -----GETTERS AND SETTERS-----
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetId()
    {
        return _id;
    }
    public void SetId(string id)
    {
        _id = id;
    }

    public string GetAddress()
    {
        return _address;
    }
    public void SetAddress(string address)
    {
        _address = address;
    }

    public string GetBirthday()
    {
        return _birthday;
    }
    public void SetBirthday(string birthday)
    {
        _birthday = birthday;
    }
    // -----METHODS-----
    public abstract float GetPay(); // ABSTRACT keyword tells the compiler that this method must be implemented in derived classes
}
