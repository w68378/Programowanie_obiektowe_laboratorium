using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = new int[10];
        Console.WriteLine("Podaj 10 liczb całkowitych:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Liczba {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int suma = numbers.Sum();
        int iloczyn = numbers.Aggregate(1, (acc, x) => acc * x);
        double srednia = numbers.Average();
        int min = numbers.Min();
        int max = numbers.Max();

        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Iloczyn: {iloczyn}");
        Console.WriteLine($"Średnia: {srednia}");
        Console.WriteLine($"Minimalna wartość: {min}");
        Console.WriteLine($"Maksymalna wartość: {max}");
    }
}
