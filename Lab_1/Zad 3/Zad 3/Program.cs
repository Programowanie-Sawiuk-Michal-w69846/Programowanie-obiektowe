using System;

class Program
{
    static void Main()
    {
        double[] tablica = new double[10];
        Console.WriteLine("Wprowadź 10 liczb:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Liczba {i + 1}: ");
            tablica[i] = double.Parse(Console.ReadLine());
        }

        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Wyświetl od pierwszego do ostatniego");
            Console.WriteLine("2. Wyświetl od ostatniego do pierwszego");
            Console.WriteLine("3. Elementy o nieparzystych indeksach");
            Console.WriteLine("4. Elementy o parzystych indeksach");
            Console.WriteLine("5. Wyjście");
            Console.Write("Wybierz opcję: ");
            int wybor = int.Parse(Console.ReadLine());

            if (wybor == 5) break;

            if (wybor == 1)
            {
                for (int i = 0; i < 10; i++) Console.Write(tablica[i] + " ");
                Console.WriteLine();
            }
            else if (wybor == 2)
            {
                for (int i = 9; i >= 0; i--) Console.Write(tablica[i] + " ");
                Console.WriteLine();
            }
            else if (wybor == 3)
            {
                for (int i = 1; i < 10; i += 2) Console.Write(tablica[i] + " ");
                Console.WriteLine();
            }
            else if (wybor == 4)
            {
                for (int i = 0; i < 10; i += 2) Console.Write(tablica[i] + " ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Nieprawidłowy wybór.");
            }
        } while (true);
    }
}