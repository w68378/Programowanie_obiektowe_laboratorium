using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę elementów do posortowania: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Liczba {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        BubbleSort(numbers);

        Console.WriteLine("Posortowane liczby:");
        foreach (var num in numbers)
            Console.Write(num + " ");
    }

    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}
