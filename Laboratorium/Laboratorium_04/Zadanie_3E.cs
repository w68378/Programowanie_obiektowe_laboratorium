using System;
using System.Collections.Generic;

interface IOsoba
{
    string Imie { get; set; }
    string Nazwisko { get; set; }
    string ZwrocPelnaNazwe();
}

interface IProwadzacy : IOsoba
{
    string TytulNaukowy { get; set; }
    List<string> Przedmioty { get; set; }

    void DodajPrzedmiot(string przedmiot);
    void WyswietlPrzedmioty();
}

class Prowadzacy : IProwadzacy
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string TytulNaukowy { get; set; }
    public List<string> Przedmioty { get; set; } = new List<string>();

    public string ZwrocPelnaNazwe() => $"{TytulNaukowy} {Imie} {Nazwisko}";

    public void DodajPrzedmiot(string przedmiot)
    {
        Przedmioty.Add(przedmiot);
    }

    public void WyswietlPrzedmioty()
    {
        Console.WriteLine($"Prowadzący: {ZwrocPelnaNazwe()}, Przedmioty:");
        foreach (var przedmiot in Przedmioty)
        {
            Console.WriteLine($"- {przedmiot}");
        }
    }
}

class Program
{
    static void Main()
    {
        Prowadzacy prowadzacy = new Prowadzacy
        {
            Imie = "Anna",
            Nazwisko = "Nowak",
            TytulNaukowy = "Dr"
        };

        prowadzacy.DodajPrzedmiot("Matematyka");
        prowadzacy.DodajPrzedmiot("Fizyka");
        prowadzacy.DodajPrzedmiot("Informatyka");

        prowadzacy.WyswietlPrzedmioty();
    }
}
