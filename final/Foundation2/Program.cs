using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Product Manager\n");

        //PRODUCT INFO
        Product ranchDressing = new Product("Ranch Dressing", "RD23555", 5.99, 1);
        Product bread = new Product("White Bread", "WB18332", 3.78, 2);
        Product deoderant = new Product("Old Spice Deoderant", "OSD4732", 5.99, 1);
        Product milk = new Product("1% Milk", "1P3432", 3.45, 2);
        Product headphones = new Product("Beats Studio 3", "BS323", 249.99, 1);
        Product ipad = new Product("Apple iPad Air", "AIA355", 599.99, 1);
        Product nintendoSwitch = new Product("Nintendo Switch", "NS2234", 299.99, 1);
        Product mansion = new Product("HUGE MANSION", "M10000000", 1450000000.00, 1);

        //CUSTOMER 1 INFO
        Address address1 = new Address("123 Main St.", "Salt Lake City", "Utah", "USA");
        Customer customer1 = new Customer("Kirk Staples", address1);

        //CUSTOMER 2 INFO
        Address address2 = new Address("68 Rua de Sao Sebastiao 1 Esq", "Benfica", "Lisbon", "Portugal");
        Customer customer2 = new Customer("Joao Batista", address2);

        //CUSTOMER 3 INFO
        Address address3 = new Address("1 Wealthy Blvd", "Los Angeles", "California", "USA");
        Customer customer3 = new Customer("Rich 'Dolla Dolla' Bills", address3);

        //ORDER 1
        Order order1 = new Order(customer1);
        order1.AddProduct(ranchDressing);
        order1.AddProduct(bread);
        order1.AddProduct(milk);

        //ORDER 2
        Order order2 = new Order(customer2);
        order2.AddProduct(bread);
        order2.AddProduct(deoderant);
        order2.AddProduct(headphones);
        order2.AddProduct(ipad);

        //ORDER 3
        Order order3 = new Order(customer3);
        order3.AddProduct(ranchDressing);
        order3.AddProduct(bread);
        order3.AddProduct(deoderant);
        order3.AddProduct(milk);
        order3.AddProduct(headphones);
        order3.AddProduct(ipad);
        order3.AddProduct(nintendoSwitch);
        order3.AddProduct(mansion);

        //DISPLAY ORDER 1
        Console.WriteLine("Order 1");
        Console.WriteLine(" Packing Label:");
        Console.WriteLine($"   {order1.CreatePackingLabel()}\n");
        Console.WriteLine(" Shipping Label:");
        Console.WriteLine($"   {order1.CreateShippingLabel()}\n");
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");
        Console.WriteLine("-------------------------------");

        //DISPLAY ORDER 2
        Console.WriteLine("Order 2");
        Console.WriteLine(" Packing Label:");
        Console.WriteLine($"   {order2.CreatePackingLabel()}\n");
        Console.WriteLine(" Shipping Label:");
        Console.WriteLine($"   {order2.CreateShippingLabel()}\n");
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}\n");
        Console.WriteLine("-------------------------------");

        //DISPLAY ORDER 3
        Console.WriteLine("Order 3");
        Console.WriteLine(" Packing Label:");
        Console.WriteLine($"   {order3.CreatePackingLabel()}\n");
        Console.WriteLine(" Shipping Label:");
        Console.WriteLine($"   {order3.CreateShippingLabel()}\n");
        Console.WriteLine($"Total Cost: ${order3.GetTotalCost()}\n");
        Console.WriteLine("-------------------------------");
    }
}