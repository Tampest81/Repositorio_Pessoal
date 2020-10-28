using System;

namespace _19._10._2020_Array._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos Hóspedes?");
            int qntHospede = int.Parse(Console.ReadLine());

            InfoHospede[] vect = new InfoHospede[qntHospede];

            int Quartos = 9;

            int[] count = new int[Quartos];

            for (int i = 0; i < qntHospede; i++)
            {
                Console.WriteLine("Hospede Nº: " + (i + 1));

                Console.Write("Quarto: ");
                int Counter = int.Parse(Console.ReadLine());

                count[i] = Counter;

                Console.Write("Nome: ");
                string Name = Console.ReadLine();
                Console.Write("Email: ");
                string Email = Console.ReadLine();

                vect[i] = new InfoHospede { Counter = Counter, Name = Name, Email = Email };

            }
                for (int o = 0; o<qntHospede; o++)
                {
                Console.WriteLine("Nº do Quarto : " + count[o] + "|| Name: " + vect[o].Name + "|| Email: " + vect[o].Email);
                }

        }

            
    }
    
}
