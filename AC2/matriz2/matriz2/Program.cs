using System;

namespace matriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Colunas: ");
            int c = int.Parse(Console.ReadLine()); // irá salvar a variavel c que será inputada pelo usuario
            Console.WriteLine("Linhas: ");
            int l = int.Parse(Console.ReadLine());// irá salvar a variavel l que será inputada pelo usuario

            int[,] matriz = new int[c, l];// criação da matriz, c x l

            int count = 1; // contador

            for(int i = 0; i<l; i++) // criação do for para inputar as colunas
            {
                for(int j = 0; j<c; j++) // criação do segundo for para inputar as linhas
                {
                    Console.WriteLine("Escreva o valor nº " + count + " da matriz"); // console contado os valores para direcionar o usuario
                    int a = int.Parse(Console.ReadLine());// valor a que será salvo para ser adicionado à matriz
                    matriz[j, i] = a; // valor a sendo adicionado à matriz como um valor, na linha j, e coluna i
                }

                count++; // contador para o localizar o usuario
            }

            Console.WriteLine("Matriz: "); // titulo

            for(int i = 0; i<l; i++) // for para contar as colunas
            {
                for( int j = 0; j < c;j++ ) // for para contar as linhas
                {
                    Console.Write(matriz[j, i]); // console ira escrever a matriz de uma maneira visual mais agradavel
                    // exemplo:
                    // 1 2 3
                    // 4 5 6
                    // 7 8 9
                }
                Console.WriteLine("");// espaçamento
            }

            Console.WriteLine("Escolha um valor da matriz: "); 
            int b = int.Parse(Console.ReadLine()); // input b do usuario que será redirecionado à um if

            for (int i = 0; i < l; i++) // um for para contar as colunas
            {
                for (int j = 0; j < c; j++) // um for para contar as linhas
                {
                    if (matriz[j,i] == b) // um if para verificar se o b existe na matriz, e a localização
                    {
                        if(j + 1 < c) // verificar se existe valor para a direita
                        {
                            Console.WriteLine("Direita: " + matriz[j+1, i]);
                        }
                        else // feedback para não existencia do valor
                        {
                            Console.WriteLine("Direita: Fora dos limites da matriz");
                        }
                        if (j - 1 >= 0) // verificar se existe valor para a esquerda
                        {
                            Console.WriteLine("Esquerda: " + matriz[j - 1, i]);
                        }
                        else // feedback para não existencia do valor
                        {
                            Console.WriteLine("Esquerda: Fora dos limites da matriz");
                        }
                        if (i - 1 >= 0) // verificar se existe valor para cima
                        {
                            Console.WriteLine("Cima: " + matriz[j, i - 1]);
                        }
                        else // feedback para não existencia do valor
                        {
                            Console.WriteLine("P/ Cima: Fora dos limites da matriz");
                        }
                        if (i + 1 < l) // verificar se existe valor para baixo
                        {
                            Console.WriteLine("Baixo: " + matriz[j, i + 1]);
                        }
                        else // feedback para não existencia do valor
                        {
                            Console.WriteLine("P/ Baixo: Fora dos limites da matriz");
                        }

                    }
                }
                Console.WriteLine(""); // espaçamento
            }


        }
    }
}
