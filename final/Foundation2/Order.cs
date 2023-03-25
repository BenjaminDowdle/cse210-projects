public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.Price * product.Quantity;
        }
        if (_customer.Address.IsInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        totalCost = Math.Round(totalCost, 2);

        return totalCost;
    }

    public string CreatePackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"{product.Name} ({product.Id})\n";
        }
        return label;
    }

    public string CreateShippingLabel()
    {
        string label = $"{_customer.Name}\n\n{_customer.Address.ToString()}";
        return label;
    }
}
