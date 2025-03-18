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
        Adres adres = new Adres("Полоцк", "Зыгина", 10);
        Adres adres1 = new Adres("Новополоцк", "Денисова", 13);
        adres.ShowAdres();
        adres1.ShowAdres();

        Console.ReadLine();
    }
}
