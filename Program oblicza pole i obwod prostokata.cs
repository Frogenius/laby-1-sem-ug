

using System;

namespace PoleProstokata
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, pole, obwód;

            Console.WriteLine("Program oblicza pole i obwod prostokata.");

            Console.WriteLine("Podaj bok a.");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj bok b.");
            b = double.Parse(Console.ReadLine());

            pole = a * b;
            obwód = (a + b) * 2;

            Console.Write("Pole prostokata o boku a = {0} i boku b = {1}", a, b);
            Console.Write(" wynosi {0}.", pole);
            Console.Write("Pole prostokata o boku a = {0} i boku b = {1}", a, b);
            Console.Write(" wynosi {0}.", obwód);


            Console.Read();
        }
    }
}