using System;

namespace MatrizBidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite o número de linhas da matriz:");
            int linhas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de colunas da matriz:");
            int colunas = int.Parse(Console.ReadLine());

            int[,] matriz = new int [linhas,colunas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.WriteLine($"Digite o valor da posição({i},{j})");
                    matriz[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matriz bidimensional preenchida:");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write(matriz[i,j] + "\t");
                }
                Console.WriteLine();
            }

            float soma = 0f;
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    soma += matriz[i,j];
                }
            }
            Console.WriteLine($"A soma dos valores da matriz é: {soma}");

            Console.WriteLine("Digite o valor que deseja buscar a posição:");
            int valor = int.Parse(Console.ReadLine());
            bool valorEncontrado = false;
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (valor == matriz[i,j])
                    {
                        Console.WriteLine($"A posição do valor {valor} é: ({i},{j})");
                        valorEncontrado = true;
                    }
                }
            }
            if (!valorEncontrado)
            {
                Console.WriteLine($"O valor {valor} não foi atribuido à matriz");
            }
        }
    }
}