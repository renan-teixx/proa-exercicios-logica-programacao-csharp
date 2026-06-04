using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex06TesteDeParidade
    {
        public static void Main(String[] args)
        {
            int numero;

            Console.WriteLine("Verifica se um número inteiro digitado é par.");

            Console.WriteLine("\nDigite um número inteiro: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0) {
                Console.WriteLine("\nO número é par");
            }
        }
    }
}
