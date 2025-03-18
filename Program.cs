using System;

class Adres
{
    public string City;
    public string Streat;
    public int Numhouse;

    public Adres(string city, string streat, int numhouse)
    {
        City = city;
        Streat = streat;
        Numhouse = numhouse;
    }

    public void ShowAdres()
    {
        Console.WriteLine($"Адрес: {City}, ул. {Streat}, д. {Numhouse}");
    }
}

class Program
{
    static void Main()
    {
        Adres adres = new Adres("Москва", "Ленина", 10);
        adres.ShowAdres();

        Console.ReadLine();
    }
}
