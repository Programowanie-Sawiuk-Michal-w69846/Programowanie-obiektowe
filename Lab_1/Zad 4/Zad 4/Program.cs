using System;

class Program
{
    static void Main()
    {
        double[] liczby = new double[10];
        Console.WriteLine("Wprowadź 10 liczb:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Liczba {i + 1}: ");
            liczby[i] = double.Parse(Console.ReadLine());
        }

        double suma = 0, iloczyn = 1, min = liczby[0], max = liczby[0];
        foreach (double liczba in liczby)
        {
            suma += liczba;
            iloczyn *= liczba;
            if (liczba < min) min = liczba;
            if (liczba > max) max = liczba;
        }

        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Iloczyn: {iloczyn}");
        Console.WriteLine($"Średnia: {suma / liczby.Length}");
        Console.WriteLine($"Minimalna: {min}");
        Console.WriteLine($"Maksymalna: {max}");
    }
}