using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex08Multiplos
    {
        public static void Main(String[] args)
        {
            int numero1, numero2;

            Console.WriteLine("Verifica se o primeiro número digitado é múltiplo do segundo.");

            Console.WriteLine("\nDigite o primeiro número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite o segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 % numero2 == 0) 
            {
                Console.WriteLine("\nO primeiro número é múltiplo do segundo.");
            }
        }
    }
}
