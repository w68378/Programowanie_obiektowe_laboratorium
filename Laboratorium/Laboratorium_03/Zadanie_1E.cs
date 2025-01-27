using System;
using System.Collections.Generic;

class Person
{
    private string FirstName { get; set; }
    private string LastName { get; set; }
    private int Wiek { get; set; }

    public Person(string firstName, string lastName, int wiek)
    {
        FirstName = firstName;
        LastName = lastName;
        Wiek = wiek;
    }

    public virtual void View()
    {
        Console.WriteLine($"Imię: {FirstName}, Nazwisko: {LastName}, Wiek: {Wiek}");
    }
}

class Program
{
    static void Main()
    {
        Person osoba = new Person("Jan", "Kowalski", 40);
        osoba.View();
    }
}
