using System;
using System.Collections.Generic;

enum Kolor { Czerwony, Niebieski, Zielony, Żółty, Fioletowy }

class GraKolory
{
    static List<Kolor> dostepneKolory = new List<Kolor> { Kolor.Czerwony, Kolor.Niebieski, Kolor.Zielony, Kolor.Żółty, Kolor.Fioletowy };

    public static void Start()
    {
        Random rand = new Random();
        Kolor wylosowanyKolor = dostepneKolory[rand.Next(dostepneKolory.Count)];

        Console.WriteLine("Zgadnij kolor: Czerwony, Niebieski, Zielony, Żółty, Fioletowy");
        bool odgadniete = false;

        while (!odgadniete)
        {
            try
            {
                Console.Write("Podaj kolor: ");
                Kolor wybor = (Kolor)Enum.Parse(typeof(Kolor), Console.ReadLine(), true);

                if (wybor == wylosowanyKolor)
                {
                    Console.WriteLine("Gratulacje! Zgadłeś kolor.");
                    odgadniete = true;
                }
                else
                {
                    Console.WriteLine("Spróbuj ponownie!");
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Błąd: Wpisano niepoprawny kolor.");
            }
        }
    }
}