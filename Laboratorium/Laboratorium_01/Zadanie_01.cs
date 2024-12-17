using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Program oblicza wyróżnik delta i pierwiastki trójmianu kwadratowego.");
        Console.Write("Podaj współczynnik a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Podaj współczynnik b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Podaj współczynnik c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double delta = Math.Pow(b, 2) - 4 * a * c;
        Console.WriteLine($"Δ = {delta}");

        if (delta < 0)
        {
            Console.WriteLine("Brak pierwiastków rzeczywistych.");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Jeden pierwiastek: x₀ = {x}");
        }
        else
        {
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Dwa pierwiastki:");
            Console.WriteLine($"x₁ = {x1}");
            Console.WriteLine($"x₂ = {x2}");
        }
    }
}
