using System;
using System.Collections.Generic;

class Reviewer : Reader
{
    public Reviewer(string firstName, string lastName, int wiek) : base(firstName, lastName, wiek) { }

    public void WypiszZRecenzjami()
    {
        Console.WriteLine($"Recenzje książek przeczytanych przez {FirstName} {LastName}:");
        Random rand = new Random();
        foreach (var ksiazka in PrzeczytaneKsiazki)
        {
            Console.WriteLine($"- {ksiazka.Title}, Ocena: {rand.Next(1, 6)}/5");
        }
    }
}

class Program
{
    static void Main()
    {
        Person author = new Person("Jan", "Kowalski", 45);
        Book book1 = new Book("C# dla początkujących", author, 2023);
        Book book2 = new Book("Zaawansowany C#", author, 2024);

        Reviewer reviewer = new Reviewer("Tomasz", "Wiśniewski", 35);
        reviewer.DodajKsiazke(book1);
        reviewer.DodajKsiazke(book2);

        reviewer.View();
        reviewer.WypiszZRecenzjami();
    }
}
