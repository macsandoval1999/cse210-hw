public class Product
{
    // MEMBER VARIABLES
    private string _name;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;

    // CONSTRUCTOR
    public Product(string name, string productId, double pricePerUnit, int quantity) 
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }
    public Product(string name, string productId, double pricePerUnit) 
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = 1; // Default quantity to 1 if not specified
    }

    //METHODS
    public double GetTotalProductCost() //Calculate total price
    {
        return _pricePerUnit * _quantity;
    }
    public string GetProductInfo() //Get product description
    {
        return $"{_productId} {_name} x{_quantity}";
    }

    // GETTERS AND SETTERS
    public string GetName() //Retrieve product name
    {
        return _name;
    }
    public void SetName(string name) //Set product name
    {
        _name = name;
    }
    public string GetProductId() //Retrieve product ID
    {
        return _productId;
    }
    public void SetProductId(string productId) //Set product ID
    {
        _productId = productId;
    }
    public double GetPricePerUnit() //Retrieve price per unit
    {
        return _pricePerUnit;
    }
    public void SetPricePerUnit(double pricePerUnit) //Set price per unit
    {
        _pricePerUnit = pricePerUnit;
    }
    public int GetQuantity() //Retrieve quantity
    {
        return _quantity;
    }
    public void SetQuantity(int quantity) //Set quantity
    {
        _quantity = quantity;
    }

}
