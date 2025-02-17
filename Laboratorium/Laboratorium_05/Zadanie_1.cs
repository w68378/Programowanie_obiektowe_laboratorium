using System;
using System.Collections.Generic;

enum Operacja { Dodawanie, Odejmowanie, Mnożenie, Dzielenie }

class Kalkulator
{
    static List<double> historiaWynikow = new List<double>();

    static double WykonajOperacje(double a, double b, Operacja operacja)
    {
        switch (operacja)
        {
            case Operacja.Dodawanie: return a + b;
            case Operacja.Odejmowanie: return a - b;
            case Operacja.Mnożenie: return a * b;
            case Operacja.Dzielenie:
                if (b == 0)
                    throw new DivideByZeroException("Nie można dzielić przez zero.");
                return a / b;
            default: throw new ArgumentException("Nieznana operacja.");
        }
    }

    public static void Start()
    {
        try
        {
            Console.Write("Podaj pierwszą liczbę: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Wybierz operację (Dodawanie, Odejmowanie, Mnożenie, Dzielenie): ");
            Operacja operacja = (Operacja)Enum.Parse(typeof(Operacja), Console.ReadLine(), true);

            double wynik = WykonajOperacje(a, b, operacja);
            historiaWynikow.Add(wynik);

            Console.WriteLine($"Wynik: {wynik}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Błąd: Wprowadź poprawne liczby.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
} 