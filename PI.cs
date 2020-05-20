using System;

namespace StałaPi
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, pole, obwód;


            Console.WriteLine("Pi = {0:#.#}", Math.PI);
            Console.WriteLine("Pi = {0:#.##}", Math.PI);
            Console.WriteLine("Pi = {0:#.###}", Math.PI);

            Console.WriteLine("Podaj promień:");

            r = double.Parse(Console.ReadLine());
            pole = Math.PI * r * r;
            obwód = Math.PI * r * 2;

            Console.Write("Pole", r);
            Console.Write(" wynosi {0}.", pole);
            Console.Write("obwód", r);
            Console.Write(" wynosi {0}.", obwód);

            Console.Read();
        }
    }
}