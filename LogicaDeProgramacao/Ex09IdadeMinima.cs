using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex09IdadeMinima
    {
        public static void Main(String[] args)
        {
            int anoNasc, anoAtual;
                
            Console.WriteLine("Verifica se é maior de idade.");

            Console.WriteLine("\nDigite o ano atual: ");
            anoAtual= Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nDigite seu ano de nascimento: ");
            anoNasc= Convert.ToInt16(Console.ReadLine());

            if (anoAtual - anoNasc >= 18)
            {
                Console.WriteLine("\nMaior de idade");
            }
        }
    }
}
