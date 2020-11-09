using System;
using System.Numerics;

namespace _19._10._2020_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double somaTotal = 0;
            // input para definir o tamaho do array
            Console.WriteLine("Quantidade:");

            int n = int.Parse(Console.ReadLine());
            double[] vetor = new double[n];
            // um for para poder enumerar e colocar valor no array
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o numero nº " + (i+1));

                vetor[i] = double.Parse(Console.ReadLine());

                somaTotal = somaTotal + vetor[i];
            }
            
            Console.WriteLine("Quantidade De Numeros: " + n);
            Console.WriteLine("Valor Total: " + somaTotal);
            Console.WriteLine("Média: " + somaTotal/n);
        }
    }
}
