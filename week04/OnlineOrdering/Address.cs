using System;
using System.Collections.Generic;

/*
Address:

attributes:
_streetAddress: string
_city: string
_state/providence: string
_country: string

methods;
IsInUSA(): bool
DisplayAddress(): string. (Newline characters where appropriate)
*/

class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    public string DisplayAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }
}