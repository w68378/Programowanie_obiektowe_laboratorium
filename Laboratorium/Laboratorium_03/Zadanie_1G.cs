using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Person author = new Person("Jan", "Kowalski", 45);
        Book book1 = new Book("C# dla początkujących", author, 2023);
        Book book2 = new Book("Zaawansowany C#", author, 2024);

        Reader reader = new Reader("Anna", "Nowak", 30);
        reader.DodajKsiazke(book1);

        Reviewer reviewer = new Reviewer("Tomasz", "Wiśniewski", 35);
        reviewer.DodajKsiazke(book2);

        List<Person> osoby = new List<Person> { reader, reviewer };

        Console.WriteLine("Lista osób i ich książki:");
        foreach (var osoba in osoby)
        {
            osoba.View();
        }
    }
}
