using System;
using System.Collections.Generic;

class Reader : Person
{
    private List<Book> PrzeczytaneKsiazki = new List<Book>();

    public Reader(string firstName, string lastName, int wiek) : base(firstName, lastName, wiek) { }

    public void DodajKsiazke(Book ksiazka)
    {
        PrzeczytaneKsiazki.Add(ksiazka);
    }

    public override void View()
    {
        base.View();
        Console.WriteLine("Książki przeczytane:");
        foreach (var ksiazka in PrzeczytaneKsiazki)
        {
            ksiazka.View();
        }
    }
}

class Program
{
    static void Main()
    {
        Person author = new Person("Jan", "Kowalski", 45);
        AdventureBook advBook = new AdventureBook("Przygody w górach", author, 2022, "Tatry");
        DocumentaryBook docBook = new DocumentaryBook("Historia komputerów", author, 2021, "Informatyka");

        Reader reader = new Reader("Anna", "Nowak", 30);
        reader.DodajKsiazke(advBook);
        reader.DodajKsiazke(docBook);

        reader.View();
    }
}
