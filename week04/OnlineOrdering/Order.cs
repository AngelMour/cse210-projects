using System;
using System.Collections.Generic;


/*
Class Order:

attributes:
_products: List<Products>
_customer: string

methods;
TotalPrice(): double (sum of TotalCostProduct() + shipping cost)
    USA $5 else $35
 
GetPackingLabel(): string (name and product ID)
GetShippingLabel(): string (name and address
*/

class Order
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

    public double TotalPrice()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.TotalCostProduct();
        }
        total += _customer.GetIsInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += product.GetPackingLabel() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + _customer.GetShippingLabel();
    }
}
