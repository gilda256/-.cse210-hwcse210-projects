public class Product
{
    private string _name;
    private int _productId;
    private float _price;
    private int _quantity;

    public Product(string name, int id, float price, int quantity)
    {
        _name = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
     { return _name; }
    public void SetName(string value)
     { _name = value; }

    public int GetProductId()
     { return _productId; }
    
    public float GetPrice()
     { return _price; }
    public void SetPrice(float value)
     { _price = value; }

    public int GetQuantity()
     { return _quantity; }
    public void SetQuantity(int value)
     { _quantity = value; }

    public float CalculateTotal()
    {
        return _price * _quantity;
    }
}
