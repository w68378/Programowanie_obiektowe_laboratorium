using System;

class Program
{
    static void Main()
    {
        double[] numbers = new double[10];
        Console.WriteLine("Podaj 10 liczb:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Liczba {i + 1}: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Wyświetl tablicę od pierwszego do ostatniego indeksu.");
            Console.WriteLine("2. Wyświetl tablicę od ostatniego do pierwszego indeksu.");
            Console.WriteLine("3. Wyświetl elementy o nieparzystych indeksach.");
            Console.WriteLine("4. Wyświetl elementy o parzystych indeksach.");
            Console.WriteLine("0. Wyjście.");
            Console.Write("Wybierz opcję: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 0) break;

            switch (choice)
            {
                case 1:
                    foreach (var num in numbers) Console.Write(num + " ");
                    break;
                case 2:
                    for (int i = numbers.Length - 1; i >= 0; i--) Console.Write(numbers[i] + " ");
                    break;
                case 3:
                    for (int i = 1; i < numbers.Length; i += 2) Console.Write(numbers[i] + " ");
                    break;
                case 4:
                    for (int i = 0; i < numbers.Length; i += 2) Console.Write(numbers[i] + " ");
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór.");
                    break;
            }
        }
    }
}
