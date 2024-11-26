using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj współczynniki trójmianu kwadratowego (a, b, c):");
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c: ");
        double c = double.Parse(Console.ReadLine());

        double delta = b * b - 4 * a * c;
        Console.WriteLine($"Delta = {delta}");

        if (delta > 0)
        {
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Pierwiastki: x1 = {x1}, x2 = {x2}");
        }
        else if (delta == 0)
        {
            double x0 = -b / (2 * a);
            Console.WriteLine($"Pierwiastek podwójny: x0 = {x0}");
        }
        else
        {
            Console.WriteLine("Brak pierwiastków rzeczywistych.");
        }
    }
}
