using System;

public class Product
{
    private string _name;
    private string _id;
    private float _itemPrice;
    private int _quantity;

    public Product(string name, string id, float itemPrice, int quantity)
    {
        _name = name;
        _id = id;
        _itemPrice = itemPrice;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public float GetPrice()
    {
        return _itemPrice;
    }

    public void SetPrice(float price)
    {
        _itemPrice = price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public string GetID()
    {
        return _id;
    }

    public void SetID(string id)
    {
        _id = id;
    }

    public string DisplayPackingLable()
    {
        return $"Product Info: {_name}, ID:{_id}, Cost:${_itemPrice}, Quantity:{_quantity}.";
    }
}
