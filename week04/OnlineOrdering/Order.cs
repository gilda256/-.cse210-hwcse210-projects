public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public float CalculateTotal()
    {
        float total = 0;
        
        foreach(Product p in _products)
        {
            total += p.CalculateTotal();
        }

        if(_customer.GetAddress().IsInUSA())
            total += 5;
        else
            total += 35;

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing:\n";
        foreach(Product p in _products)
        {
            label += $"{p.GetName()} (Id: {p.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $" Shipping:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}