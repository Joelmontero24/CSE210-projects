public class Product
{
    private string _name;
    private string _productId;
    private double _unitPrice;
    private int _quantity;

    public Product(string name, string productId, double unitPrice, int quantity)
    {
        _name = name;
        _productId = productId;
        _unitPrice = unitPrice;
        _quantity = quantity;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string ProductId
    {
        get => _productId;
        set => _productId = value;
    }

    public double UnitPrice
    {
        get => _unitPrice;
        set => _unitPrice = value;
    }

    public int Quantity
    {
        get => _quantity;
        set => _quantity = value;
    }

    public double GetTotalCost()
    {
        return _unitPrice * _quantity;
    }

    public string GetPackingEntry()
    {
        return $"{_name} (ID: {_productId}) x{_quantity}";
    }
}