using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex05ControleDeCommits
    {
        public static void Main(String[] args)
        {
            int quantidadeCommits;
            Console.WriteLine("Verifica se o repositório foi atualizado (commits > 0).");

            Console.WriteLine("\nDigite quantos commits você fez durante a semana: ");
            quantidadeCommits = Convert.ToInt16(Console.ReadLine());

            if (quantidadeCommits > 0)
            {
                Console.WriteLine("\nRepositório atualizado.");
            }
        }
    }
}
