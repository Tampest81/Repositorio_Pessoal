using System;
using System.Collections.Generic; // para criação de listas
using System.Globalization;
using Course.Entities;
using Course.Entities.Enums; // enumerators

namespace Course
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Forma> list = new List<Forma>(); // criação da lista list, com os parametros da classe Forma
            Console.WriteLine("Entre com o número de formas: "); // perguntará ao usuario a quantidade de formas
            int n = int.Parse(Console.ReadLine()); // salvará o numero dado pelo usuario
            for (int i = 1; i <= n; i++) // um for para repetir as perguntas de acordo com a quantidade de forma dada
            {
                Console.WriteLine($"Forma #{i}:"); // dara uma noção de qual numero o usuario está
                Console.Write("Retângulo ou Circulo(R / C) ? "); // perguntará se é um retangulo ou um circulo
                char ch = char.Parse(Console.ReadLine().ToLower()); // guardará a resposta + toLower para que o input seja sempre minusculo
                Console.Write("Cor: (Preto / Azul / Vermelho): "); // perguntará a cor
                Color cor = Enum.Parse<Color>(Console.ReadLine()); // guardará a cor

                if (ch == 'r')// se o escolhido for retangulo
                {
                    Console.Write("Largura: "); // perguntará a largura
                    double largura = double.Parse(Console.ReadLine()); // guardará a largura dada pelo usuario
                    Console.Write("Altura: "); // perguntará a altura
                    double altura = double.Parse(Console.ReadLine()); // guardará a altura dada pelo usuario
                    list.Add(new Retangulo(largura, altura, cor)); // adicionará essas variaveis na lista list
                }
                else // caso nao seja um retangulo...
                {
                    Console.WriteLine("Raio: "); // perguntará o raio
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // guardará o valor raio
                    list.Add(new Circulo(raio, cor)); // adicionará essas variaveis na lista
                }
                Console.WriteLine(); // escreverá um espaçamento
                Console.WriteLine("Área de cada forma: ");
                foreach (Forma forma in list) // um for each para aplicar um método para cada coisa que esteja guardada na lista
                {
                    Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
                    /* aplicará o método Area() em cada valor da lista guardado, e irá ver de acordo com os parametros
                    se é um circulo ou um retangulo e transformando o valor dado, que será um double ou um int, em
                    uma string para poder aparecer no console
                    */
                }

            }
        }
    }
}
