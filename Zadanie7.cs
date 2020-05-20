using System;

namespace Zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, v;
            Console.WriteLine("Podaj wartośc x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartośc y");
            y = int.Parse(Console.ReadLine());

            if ((x < 0) && (y < 0))
                z = x * y;
            else if ((x == 0) || (y == 0))
                z = 10;
            else
                z = x + y;


            Console.WriteLine("Wartośc z= " + z);

            Console.ReadKey();

        }
    }
}
