using System;
using System.Collections.Generic;


//Class Product:


//attributes:
//_name: string
//_id: int
//_quantity: int
//_price: double

//methods;
//TotalCostProduct(): double (unit price * quantity)
 

class Product
{
    private string _name;
    private int _id;
    private int _quantity;
    private double _price;

    public Product(string name, int id, int quantity, double price)
    {
        _name = name;
        _id = id;
        _quantity = quantity;
        _price = price;
    }

    public double TotalCostProduct()
    {
        return _price * _quantity;
    }

    public string GetPackingLabel()
    {
        return $"{_name} (ID: {_id})";
    }
}