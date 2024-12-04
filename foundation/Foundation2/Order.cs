using System;

public class Order
{
    private int _orderNumber;
    private List<Product> _listProducts;
    private Customer _customer;
    private float _productPrice;
    private float _shippingCost;
    private float _totalPrice;

    public Order(int orderNumber, List<Product> listProducts, Customer customer)
    {
        _orderNumber = orderNumber;
        _listProducts = listProducts;
        _customer = customer;
        _productPrice = CalculateProductPrice();
        _shippingCost = CalculateShippingCost();
        _totalPrice = CalculateTotalPrice();
    }

    public float CalculateShippingCost()
    {
        if (_customer.CustomerInUSA())
        {
            return 5f;
        }
        else
        {
            return 35f;
        }
    }

    public string DisplayShippingCost()
    {
        return $"Shipping Cost: ${_shippingCost:0.00}";
    }

    public float CalculateProductPrice()
    {
        _productPrice = 0;
        foreach (Product product in _listProducts)
        {
            _productPrice += (product.GetPrice()*product.GetQuantity());
        }
        return _productPrice;
    }

    public string DisplayTotalProductPrice()
    {
        return $"Total Cost of Products: ${_productPrice:0.00}";
    }

    public float CalculateTotalPrice()
    {
        _totalPrice = _productPrice + _shippingCost;
        return _productPrice + _shippingCost;
    }

    public string DisplayTotalPrice()
    {
        return $"Total Price: ${_totalPrice:0.00}";
    }

    public string GetPackingLabels()
    {
        string packingLabels = "";
        foreach (Product product in _listProducts)
        {
            packingLabels += product.DisplayPackingLable() + "\n";
        }
        return packingLabels.TrimEnd('\n');
    }

    public string GetShippingLabel()
    {
        return _customer.DisplayShippingLable();
    }

    public void DisplayAllOrderInfo()
    {
        Console.WriteLine($"~~~ Order #{_orderNumber} ~~~");
        Console.WriteLine(GetShippingLabel());
        Console.WriteLine(GetPackingLabels());
        Console.WriteLine(DisplayTotalProductPrice());
        Console.WriteLine(DisplayShippingCost());
        Console.WriteLine(DisplayTotalPrice());
    }
}