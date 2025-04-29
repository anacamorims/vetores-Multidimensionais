using System;
using static System.Console;

namespace vetoresMultidimensionais
{
    internal class Program
    {
        static void Main(string[] args)
        {   //unidimensional colunas apenas, somente uma dimensao 
            int[] num1 = new int[10];

            //bidimensional colunas e linhas
            int[][] num2 = new int[10][];
            // outra forma de declarar
            int[,] num3 = new int[x, z];

            WriteLine("Digite quantos numeros deseja");
            int x = Convert.ToInt32(ReadLine());

            WriteLine("Digite quantos numeros deseja por numero de tabuada ");
            int z = Convert.ToInt32(ReadLine());

            for (int i = 1; i < x + 1; i++)
            {
                for(int j = 0; j <= z; j++)
                {
                    WriteLine($"{i} X {j} = {i * j}");
                }
            }

            for(int i = 0; i < x; i++)
            {
                WriteLine("Digite o nuemro do primeiro produto");
                num3[i, 2] = 
            }

        }
    }
}
