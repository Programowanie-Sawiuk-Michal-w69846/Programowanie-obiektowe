using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nKalkulator");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Różnica");
            Console.WriteLine("3. Iloczyn");
            Console.WriteLine("4. Iloraz");
            Console.WriteLine("5. Potęga");
            Console.WriteLine("6. Pierwiastek");
            Console.WriteLine("7. Funkcje trygonometryczne");
            Console.WriteLine("8. Wyjście");
            Console.Write("Wybierz opcję: ");
            int wybor = int.Parse(Console.ReadLine());

            if (wybor == 8) break;

            if (wybor >= 1 && wybor <= 5)
            {
                Console.Write("Podaj pierwszą liczbę: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Podaj drugą liczbę: ");
                double b = double.Parse(Console.ReadLine());

                switch (wybor)
                {
                    case 1: Console.WriteLine($"Suma = {a + b}"); break;
                    case 2: Console.WriteLine($"Różnica = {a - b}"); break;
                    case 3: Console.WriteLine($"Iloczyn = {a * b}"); break;
                    case 4:
                        if (b != 0) Console.WriteLine($"Iloraz = {a / b}");
                        else Console.WriteLine("Nie dziel przez 0!");
                        break;
                    case 5: Console.WriteLine($"Potęga = {Math.Pow(a, b)}"); break;
                }
            }
            else if (wybor == 6)
            {
                Console.Write("Podaj liczbę: ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"Pierwiastek = {Math.Sqrt(a)}");
            }
            else if (wybor == 7)
            {
                Console.Write("Podaj kąt w radianach: ");
                double radiany = double.Parse(Console.ReadLine());
                Console.WriteLine($"Sin = {Math.Sin(radiany)}, Cos = {Math.Cos(radiany)}, Tan = {Math.Tan(radiany)}");
            }
            else
            {
                Console.WriteLine("Nieprawidłowy wybór.");
            }
        }
    }
}