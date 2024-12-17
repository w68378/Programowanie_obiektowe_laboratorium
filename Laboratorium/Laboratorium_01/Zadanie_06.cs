using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Podaj liczbę całkowitą: ");
            int liczba = Convert.ToInt32(Console.ReadLine());

            if (liczba < 0)
            {
                Console.WriteLine("Koniec programu.");
                break;
            }
        }
    }
}
