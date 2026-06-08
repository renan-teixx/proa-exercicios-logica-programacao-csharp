using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex32AnoBissexto
    {
        public static void Main(String[] args) 
        {
            int ano;

            Console.WriteLine("Verifica se o ano digitado é bissexto ou não.");

            Console.WriteLine("\nDigite o ano: ");
            ano = Convert.ToInt32(Console.ReadLine());

            if ((ano % 400 == 0) || (ano % 4 == 0 && ano % 100 != 0))
            {
                Console.WriteLine("\nO ano " + ano + " é bissexto");
            }
            else 
            { 
                Console.WriteLine("\nO ano " + ano + " não é bissexto");
            }
        }
    }
}
