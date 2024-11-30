using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool CustomerInUSA()
    {
        return _address.AddressInUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }

    public string DisplayShippingLable()
    {
        return $"Shipping Lable:\n{_name}\n{_address.DisplayFullAddress()}";
    }
}
