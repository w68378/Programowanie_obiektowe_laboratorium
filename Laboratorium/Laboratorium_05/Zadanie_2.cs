using System;
using System.Collections.Generic;

enum StatusZamowienia { Oczekujące, Przyjęte, Zrealizowane, Anulowane }

class Sklep
{
    static Dictionary<int, (List<string>, StatusZamowienia)> zamowienia = new Dictionary<int, (List<string>, StatusZamowienia)>();

    public static void DodajZamowienie(int numer, List<string> produkty)
    {
        zamowienia[numer] = (produkty, StatusZamowienia.Oczekujące);
    }

    public static void ZmienStatus(int numer, StatusZamowienia nowyStatus)
    {
        if (!zamowienia.ContainsKey(numer))
            throw new KeyNotFoundException("Nie znaleziono zamówienia o podanym numerze.");

        if (zamowienia[numer].Item2 == nowyStatus)
            throw new ArgumentException("Nowy status jest taki sam jak aktualny.");

        zamowienia[numer] = (zamowienia[numer].Item1, nowyStatus);
    }

    public static void WyswietlZamowienia()
    {
        foreach (var zam in zamowienia)
        {
            Console.WriteLine($"Zamówienie {zam.Key}: {string.Join(", ", zam.Value.Item1)}, Status: {zam.Value.Item2}");
        }
    }
}