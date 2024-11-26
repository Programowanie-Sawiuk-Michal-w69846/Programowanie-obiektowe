using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Podaj liczbę całkowitą: ");
            int liczba = int.Parse(Console.ReadLine());
            if (liczba < 0)
            {
                Console.WriteLine("Koniec programu.");
                break;
            }
        }
    }
}