using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Kalkulator matematyczny:");
            Console.WriteLine("1. Dodawanie (+)");
            Console.WriteLine("2. Odejmowanie (-)");
            Console.WriteLine("3. Mnożenie (*)");
            Console.WriteLine("4. Dzielenie (/)");
            Console.WriteLine("5. Potęgowanie (a^b)");
            Console.WriteLine("6. Pierwiastkowanie (√a)");
            Console.WriteLine("7. Funkcje trygonometryczne (sin, cos, tan)");
            Console.WriteLine("0. Wyjście");
            Console.Write("Wybierz opcję: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 0) break;

            Console.Write("Podaj pierwszą liczbę (a): ");
            double a = Convert.ToDouble(Console.ReadLine());

            if (choice == 7)
            {
                Console.WriteLine($"sin(a) = {Math.Sin(a)}");
                Console.WriteLine($"cos(a) = {Math.Cos(a)}");
                Console.WriteLine($"tan(a) = {Math.Tan(a)}");
            }
            else
            {
                Console.Write("Podaj drugą liczbę (b): ");
                double b = Convert.ToDouble(Console.ReadLine());
                switch (choice)
                {
                    case 1: Console.WriteLine($"a + b = {a + b}"); break;
                    case 2: Console.WriteLine($"a - b = {a - b}"); break;
                    case 3: Console.WriteLine($"a * b = {a * b}"); break;
                    case 4: Console.WriteLine(b != 0 ? $"a / b = {a / b}" : "Błąd: Dzielenie przez zero!"); break;
                    case 5: Console.WriteLine($"a^b = {Math.Pow(a, b)}"); break;
                    case 6: Console.WriteLine(a >= 0 ? $"√a = {Math.Sqrt(a)}" : "Błąd: Pierwiastek z liczby ujemnej!"); break;
                    default: Console.WriteLine("Niepoprawny wybór."); break;
                }
            }
        }
    }
}
