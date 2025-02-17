using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

class AnalizaPopulacji
{
    private static Dictionary<string, Dictionary<int, long>> Populacja = new();

    public static void WczytajDane(string fileName)
    {
        string json = File.ReadAllText(fileName);
        Populacja = JsonSerializer.Deserialize<Dictionary<string, Dictionary<int, long>>>(json);
    }

    public static long ObliczRoznice(string kraj, int rokStart, int rokKoniec)
    {
        return Populacja[kraj][rokKoniec] - Populacja[kraj][rokStart];
    }

    public static void PokazPopulacje(string kraj, int rok)
    {
        Console.WriteLine($"Populacja {kraj} w roku {rok}: {Populacja[kraj][rok]}");
    }

    public static void ObliczWzrostProcentowy(string kraj)
    {
        var lata = Populacja[kraj].Keys.OrderBy(x => x).ToList();
        for (int i = 1; i < lata.Count; i++)
        {
            double wzrost = ((double)(Populacja[kraj][lata[i]] - Populacja[kraj][lata[i - 1]]) / Populacja[kraj][lata[i - 1]]) * 100;
            Console.WriteLine($"Wzrost w {lata[i]}: {wzrost:F2}%");
        }
    }
}
