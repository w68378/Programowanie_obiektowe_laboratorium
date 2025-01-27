using System;
using System.Collections.Generic;

interface IOsoba
{
    string Imie { get; set; }
    string Nazwisko { get; set; }
    string ZwrocPelnaNazwe();
}

class Osoba : IOsoba
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }

    public string ZwrocPelnaNazwe() => $"{Imie} {Nazwisko}";
}

class Program
{
    static void Main()
    {
        List<IOsoba> osoby = new List<IOsoba>
        {
            new Osoba { Imie = "Jan", Nazwisko = "Kowalski" },
            new Osoba { Imie = "Anna", Nazwisko = "Nowak" },
            new Osoba { Imie = "Piotr", Nazwisko = "Adamski" }
        };

        Console.WriteLine("Lista osób:");
        foreach (var osoba in osoby)
        {
            Console.WriteLine(osoba.ZwrocPelnaNazwe());
        }
    }
}
