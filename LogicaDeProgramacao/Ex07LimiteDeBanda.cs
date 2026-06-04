using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex07LimiteDeBanda
    {
        public static void Main(String[] args)
        {
            int quantidadeTrafegoRede, quantidadeExcedente, valorTaxa;

            Console.WriteLine("Calcula o valor da taxa de internet a partir de 100 GB.");

            Console.WriteLine("\nDigite a quantidade em GB de dados gastos: ");
            quantidadeTrafegoRede = Convert.ToInt32(Console.ReadLine());

            if (quantidadeTrafegoRede > 100)
            {
                quantidadeExcedente = quantidadeTrafegoRede - 100;

                valorTaxa = quantidadeExcedente * 5;

                Console.WriteLine("\nO valor da taxa é de R$"+valorTaxa);
            }  
        }
    }
}
