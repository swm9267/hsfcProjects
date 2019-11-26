using System;
using System.Collections.Generic;
using System.Text;

namespace Coach_Project
{
    public class Address
    {
    private string country = "";
    private string city = "";
    private string streetName = "";
    private int houseNumber = 0;
    private string postCode = "";

    public Address(String theCountry, String theCity, String theStreetName, int theHouseNumber, String thePostCode)
    {
        country = theCountry;
        city = theCity;
        streetName = theStreetName;
        houseNumber = theHouseNumber;
        postCode = thePostCode;
    }

    public Address()
    {

    }

    public void SetCountry(String theCountry)
    {
        country = theCountry;
    }

    public String GetCountry()
    {
        return country;
    }

    public void SetCity(String theCity)
    {
        city = theCity;
    }

    public String GetCity()
    {
        return city;
    }

    public void SetStreetName(String theStreetName)
    {
        streetName = theStreetName;
    }

    public String GetStreetName()
    {
        return streetName;
    }

    public void SetHouseNumber(int theHouseNumber)
    {
        houseNumber = theHouseNumber;
    }

    public int GetHouseNumber()
    {
        return houseNumber;
    }

    public void SetPostCode(String thePostCode)
    {
        postCode = thePostCode;
    }

    public String GetPostCode()
    {
        return postCode;
    }
    public override string ToString()
    {
        return this.GetCountry() + ", " + this.GetCity() + ", " + this.GetHouseNumber() + " " + this.GetStreetName() + ", " + this.GetPostCode();
    }
}
}
