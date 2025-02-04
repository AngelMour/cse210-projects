using System;
using System.Collections.Generic;

/*
Class Customer:

attributes:
_name: string
_address: Address

methods;
GetIsInUSA(): bool
*/
class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool GetIsInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetShippingLabel()
    {
        return $"{_name}\n{_address.DisplayAddress()}";
    }
}