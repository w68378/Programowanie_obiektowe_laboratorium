using System;

class Sumator
{
    private int[] Liczby;

    public Sumator(int[] liczby)
    {
        Liczby = liczby ?? throw new ArgumentNullException(nameof(liczby));
    }

    public int Suma()
    {
        int suma = 0;
        foreach (int liczba in Liczby)
            suma += liczba;
        return suma;
    }

    public int SumaPodziel2()
    {
        int suma = 0;
        foreach (int liczba in Liczby)
        {
            if (liczba % 2 == 0)
                suma += liczba;
        }
        return suma;
    }

    public int IleElementow()
    {
        return Liczby.Length;
    }

    public void WypiszElementy()
    {
        Console.WriteLine($"Elementy tablicy: {string.Join(", ", Liczby)}");
    }

    public void WypiszZakres(int lowIndex, int highIndex)
    {
        for (int i = lowIndex; i <= highIndex; i++)
        {
            if (i >= 0 && i < Liczby.Length)
                Console.WriteLine($"Indeks {i}: {Liczby[i]}");
        }
    }
}
