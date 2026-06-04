using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex14ParOuImpar
    {
        public static void Main(String[] args)
        {

            int numero;

            Console.WriteLine("Verifica se um número inteiro é par ou ímpar.");

            Console.WriteLine("\nDigite o número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("\nPar");
            }
            else
            {
                Console.WriteLine("\nÍmpar");
            }
        }
    }
}
