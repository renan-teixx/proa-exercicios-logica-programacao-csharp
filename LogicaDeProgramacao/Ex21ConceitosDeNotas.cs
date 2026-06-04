using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex21ConceitosDeNotas
    {
        public static void Main(String[] args)
        {

            float notaFinal;

            Console.WriteLine("Determina a sua classificação dependendo da sua nota final.");

            Console.WriteLine("\nDigite a sua nota final: ");
            notaFinal = float.Parse(Console.ReadLine());

            if (notaFinal >= 9)
            {
                Console.WriteLine("\nA");
            }
            else if (notaFinal >= 7.5)
            {
                Console.WriteLine("\nB");
            }
            else if (notaFinal >= 6)
            {
                Console.WriteLine("\nC");
            }
            else
            {
                Console.WriteLine("\nD");
            }
        }
    }
}
