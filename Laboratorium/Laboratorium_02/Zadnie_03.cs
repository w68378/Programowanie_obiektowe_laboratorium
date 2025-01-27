using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Imie { get; private set; }
    public string Nazwisko { get; private set; }
    private List<int> Oceny;

    public Student(string imie, string nazwisko)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        Oceny = new List<int>();
    }

    public double SredniaOcen => Oceny.Any() ? Oceny.Average() : 0;

    public void DodajOcene(int ocena)
    {
        if (ocena < 1 || ocena > 6)
            throw new ArgumentException("Ocena musi być w zakresie 1-6.");
        Oceny.Add(ocena);
    }

    public void WyswietlOceny()
    {
        Console.WriteLine($"Oceny: {string.Join(", ", Oceny)}");
        Console.WriteLine($"Średnia ocen: {SredniaOcen:F2}");
    }
}
