using System;

class Licz
{
    private int value;

    public Licz(int initialValue)
    {
        value = initialValue;
    }

    public void Dodaj(int liczba)
    {
        value += liczba;
    }

    public void Odejmij(int liczba)
    {
        value -= liczba;
    }

    public void WyswietlStan()
    {
        Console.WriteLine($"Aktualna wartość: {value}");
    }
}
