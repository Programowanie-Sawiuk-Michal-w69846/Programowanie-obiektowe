using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę elementów do posortowania: ");
        int n = int.Parse(Console.ReadLine());
        double[] liczby = new double[n];

        Console.WriteLine("Wprowadź liczby:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Liczba {i + 1}: ");
            liczby[i] = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (liczby[j] > liczby[j + 1])
                {
                    double temp = liczby[j];
                    liczby[j] = liczby[j + 1];
                    liczby[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Posortowane liczby:");
        foreach (double liczba in liczby) Console.WriteLine(liczba);
    }
}