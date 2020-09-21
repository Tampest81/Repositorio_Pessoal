using Program;
using System;
using System.Security.Cryptography;

namespace Exercicio_31._08._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 a,b;

            a = new Class1();
            b = new Class1();

            Console.WriteLine("Valores A");
            a.A = float.Parse(Console.ReadLine());
            a.B = float.Parse(Console.ReadLine());
            a.C = float.Parse(Console.ReadLine());
            Console.WriteLine("Valores B");
            b.A = float.Parse(Console.ReadLine());
            b.B = float.Parse(Console.ReadLine());
            b.C = float.Parse(Console.ReadLine());

            float AreaA = a.Valor();
            float AreaB = b.Valor();

            if (AreaA > AreaB)
            {
                Console.WriteLine("Area A Maior que Area B");
            }
            else if (AreaB > AreaA)
            {
                Console.WriteLine("Area B Maior que Area A");
            }

            Console.ReadKey();
        }

    }
}
