public class Order
{
    // MEMBER VARIABLES
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    // CONSTRUCTOR
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // METHODS
    public double CalculateTotalCost() // Calculate total cost of the order
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.GetTotalProductCost();
        }
        if (_customer.IsInUSA())
        {
            totalCost += 5.00; // Flat shipping fee for USA
        }
        else
        {
            totalCost += 35.00; // Flat shipping fee for international orders
        }
        return totalCost;
    }
    public string GetPackingLabel() // Get packing label for the order
    {
        Console.WriteLine(" Packing label:");
        foreach (var product in _products)
        {
            Console.WriteLine($" {product.GetProductInfo()}");
        }
        return "";
    }
    public string GetShippingLabel() // Get shipping label for the order
    {
        return $"Shipping Label:\n{_customer.GetCustomerInfo()}";
    }
    public void AddProduct(Product product) // Add a product to the order
    {
        _products.Add(product);
    }
    public void DisplayOrderSummary(Order order) // Display the order summary
    {
        Console.WriteLine("-Order Summary:\n");
        Console.WriteLine($" {order.GetShippingLabel()}\n");
        Console.WriteLine($" {order.GetPackingLabel()}");
        Console.WriteLine($" Total Cost: {order.CalculateTotalCost():C}\n");
    }
}