using System;
using System.Text;

public class Address
{
    private int _index;
    private string _country;
    private string _city;
    private string _street;
    private string _house;
    private string _apartment;

    public int Index
    {
        get { return _index; }
        set { _index = value; }
    }

    public string Country
    {
        get { return _country; }
        set { _country = value; }
    }

    public string City
    {
        get { return _city; }
        set { _city = value; }
    }

    public string Street
    {
        get { return _street; }
        set { _street = value; }
    }

    public string House
    {
        get { return _house; }
        set { _house = value; }
    }

    public string Apartment
    {
        get { return _apartment; }
        set { _apartment = value; }
    }
}

class Task_01
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Address address = new Address();

        address.Index = 12345;
        address.Country = "Україна";
        address.City = "Київ";
        address.Street = "Вулиця";
        address.House = "1";
        address.Apartment = "2";

        Console.WriteLine($"Індекс: {address.Index}");
        Console.WriteLine($"Країна: {address.Country}");
        Console.WriteLine($"Місто: {address.City}");
        Console.WriteLine($"Вулиця: {address.Street}");
        Console.WriteLine($"Будинок: {address.House}");
        Console.WriteLine($"Квартира: {address.Apartment}");

        Console.ReadLine();
    }
}