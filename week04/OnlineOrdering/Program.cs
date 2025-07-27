using System;

class Program
{
    static void Main(string[] args)
    {
        //Order1-----------------------------------------------------
        // Create a customer(name and address)
        Customer johnCena = new Customer("John Cena", new Address("425 No Pain No Gain Avenue", "Springfield", "IL", "USA"));

        // Create an order for the customer
        Order order1 = new Order(johnCena);

        // Create products (name, product ID, price per unit, quantity)
        Product product1 = new Product("Whey Protein", "PROD001", 29.99, 2);
        Product product2 = new Product("Creatine", "PROD002", 19.99, 1);
        Product product3 = new Product("BCAA", "PROD003", 14.99);

        // Add products to the order
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Display Order Summary
        order1.DisplayOrderSummary(order1);

        // Order2-----------------------------------------------------
        Order order2 = new Order(johnCena);
        Product product4 = new Product("Protein Bar", "PROD004", 2.99, 5);
        Product product5 = new Product("Vitamins", "PROD005", 9.99, 1);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.DisplayOrderSummary(order2);

        // Order3-----------------------------------------------------
        Customer legolas = new Customer("Legolas", new Address("123 Elven Way", "Isengard", "ME", "Middle Earth"));
        Order order3 = new Order(legolas);
        Product product6 = new Product("Bow", "PROD006", 49.99, 1);
        Product product7 = new Product("Arrows", "PROD007", 14.99, 20);
        Product product8 = new Product("Elven Cloak", "PROD008", 99.99, 1);
        order3.AddProduct(product6);
        order3.AddProduct(product7);
        order3.AddProduct(product8);
        order3.DisplayOrderSummary(order3);
    }
}