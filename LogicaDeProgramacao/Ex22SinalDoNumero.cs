using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex22SinalDoNumero
    {
        public static void Main(String[] args)
        {

            int numero;

            Console.WriteLine("Verifica se um número inteiro digitado é positivo, negativo ou zero.");

            Console.WriteLine("\nDigite um número inteiro");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("\nPositivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine("\nNegativo");
            }
            else
            {
                Console.WriteLine("\nZero");
            }
        }
    }
}
