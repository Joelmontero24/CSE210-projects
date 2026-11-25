public class Order
{
    private readonly List<Product> _products = new();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public Customer Customer
    {
        get => _customer;
        set => _customer = value;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetShippingCost()
    {
        return _customer.LivesInUsa() ? 5.0 : 35.0;
    }

    public double GetTotalCost()
    {
        double productsTotal = 0.0;

        foreach (Product product in _products)
        {
            productsTotal += product.GetTotalCost();
        }

        return productsTotal + GetShippingCost();
    }

    public string GetPackingLabel()
    {
        List<string> lines = new() { "=== PACKING LABEL ===" };

        foreach (Product product in _products)
        {
            lines.Add(product.GetPackingEntry());
        }

        return string.Join("\n", lines);
    }

    public string GetShippingLabel()
    {
        return $"=== SHIPPING LABEL ===\n{_customer.GetShippingLabel()}";
    }
}