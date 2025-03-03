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

    public void ViewBook()
    {
        Console.WriteLine($"Książki przeczytane przez {FirstName} {LastName}:");
        foreach (var ksiazka in PrzeczytaneKsiazki)
        {
            Console.WriteLine($"- {ksiazka.Title}");
        }
    }

    public override void View()
    {
        base.View();
        ViewBook();
    }
}

class Program
{
    static void Main()
    {
        Person author = new Person("Jan", "Kowalski", 45);
        Book book1 = new Book("C# dla początkujących", author, 2023);

        Reader reader = new Reader("Anna", "Nowak", 30);
        reader.DodajKsiazke(book1);

        reader.View();
    }
}
