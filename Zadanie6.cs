using System;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, max;
            Console.WriteLine("Podaj liczbę a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę c");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę d");
            d = int.Parse(Console.ReadLine());

            if ((a > b) && (a > c) && (a > d))
                max = a;
            else if ((b > a) && (b > c) && (b > d))
                max = b;
            else if ((c > a) && (c > b) && (c > d))
                max = c;
            else
                max = d;

            Console.WriteLine("max= " + max);

	    Console.ReadKey();

        }
    }
}
