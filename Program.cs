using System;
using static System.Console;

namespace vetoresMultidimensionais
{
    internal class Program
    {
        static void Main(string[] args)
        {   //unidimensional colunas apenas, somente uma dimensao 
            //int[] num1 = new int[10];

            //bidimensional colunas e linhas
            //int[][] num2 = new int[10][];
            // outra forma de declarar
            //int[,] num3 = new int[x, z];

            //1) Nome do produtos
            //2) Valor unitário
            //3) Valor total dos lotes

            WriteLine("Digite quantos produtos deseja cadastrar: ");
            int qtdProduct = Convert.ToInt32(ReadLine()); //entrada

            // em c# uma matriz so pode ter um unico tipo de dado
            string[,] product = new string[qtdProduct, 3];  //matriz com 3 colunas nome, valor unitario, qtd de lote 

            for (int i = 0; i < qtdProduct; i++)
            {
                WriteLine($"Produto {i + 1}");

                Write("Nome: ");
                product[i, 0] = ReadLine(); //entrada

                Write("Valor unitário: ");
                product[i, 1] = ReadLine(); //entrada

                Write("Quantidade de lotes: ");
                product[i, 2] = ReadLine(); //entrada
            }

            double totalValueLote = 0;

            for (int i = 0; i < qtdProduct; i++)
            {
                double valueUnit = Convert.ToDouble(product[i, 1]);
                int qtdLote = Convert.ToInt32(product[i, 2]);
                double total = valueUnit * qtdLote;
                totalValueLote = total + totalValueLote;
            }

            WriteLine($"Valor total do lote: R${totalValueLote}");

        }
    }
}

