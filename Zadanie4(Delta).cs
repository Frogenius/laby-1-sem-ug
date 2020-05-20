using System;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, delta;
                     
            try
            {
                Console.Write("Podaj wartość zmiennej a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj wartość zmiennej b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj wartość zmiennej c: ");
                c = Convert.ToDouble(Console.ReadLine());

                delta = Math.Pow(b, 2) - 4 * a * c;

                if (delta > 0 || delta == 0)
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("x1= {0}\n x2= {1}", x1, x2);
                   
                }
                
                else
                {
                    Console.WriteLine("nie ma pierwiastków rzeczywistych"); 
                }

               
            }
            catch (Exception e)
            {
                Console.Write(" Bląd: "+e);
            }
            finally
            {
                Console.ReadKey();
            }

           

        }
    }
}
