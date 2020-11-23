using System;

namespace matriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escreva um numero para o tamanho da matriz:");
            int n = int.Parse(Console.ReadLine()); // variavel que será salva como o tamanho da matriz

            Console.WriteLine("");
            int[,] matriz = new int[n , n]; // criação da matriz com o valor n x n (Linha x Coluna) dada pelo usuario

            int count1 = 1; // valor n1 para contar

            for(int i = 0; i<n; i++) // criaçao do for, este primeiro for para as colunas
            {
                
                for(int p = 0; p<n; p++) // criação do for2, este segundo for para as linhas da matriz
                {
                    Console.WriteLine("Escreva o valor nº:"+count1); // o count1 aumentará gradativamente para melhorar a experiencia do usuario
                    int a = int.Parse(Console.ReadLine()); // salva uma variavel a que será dada pelo usuario para incrementar na matriz nxn
                    matriz[p, i] = a; // atribuição da variavel a na matriz p x i = n x n
                    count1++; // adiciona um ao contador
                }

                Console.WriteLine(""); // espaçamento
            }

            Console.WriteLine("");// espaçamento
            Console.WriteLine("Matriz: "); // titulo
            Console.WriteLine("");// espaçamento

            for (int q = 0; q < n; q++) // criaçao do for, este primeiro for para as colunas
            {

                for (int w = 0; w < n; w++)// criação do for2, este segundo for para as linhas da matriz
                {
                    Console.Write(matriz[w, q] + " "); // este write irá escrever todos os valores da matriz de uma maneira mais agradavel :
                    // exemplo : (3x3)
                    // 1 2 3
                    // 4 5 6
                }   // 7 8 9

                Console.WriteLine("");// espaçamento
            }

            Console.WriteLine("");// espaçamento
            Console.WriteLine("Diagonal Principal: ");// titulo
            Console.WriteLine("");// espaçamento

            for (int c = 0; c < 1; c++)// for, não tinha necessidade de por, mas para seguir um padrão optei por colocar.
            {

                for (int l = 0; l < n; l++)// criação do for2, este para pegar a diagonal principal, 1x1 / 2x2 / 3x3 , etc
                {
                    Console.Write(matriz[l, l] + " ");
                }

                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("Números Negativos: ");
            Console.WriteLine("");
                        
            int count = 0;// contador n2

            for (int c = 0; c < n; c++) // for para as colunas
            {

                for (int l = 0; l < n; l++) // for para as linhas
                {
                    if(matriz[l, c] < 0) // if para detectar se o valor lido na linha e na coluna é menor que 0 para detectar se é negativo
                    {
                        Console.WriteLine(matriz[l, c]); // escreve o valor caso passe pelo if, se passar e escrever será negativo

                        count++; // aumenta o contador
                    }

                }

                Console.WriteLine("");
            }

            Console.WriteLine("Total de numeros negativos: " + count); // irá dar a quantidade de numeros negativos, e o valor será atribuido pelo contador

        }
    }
}
