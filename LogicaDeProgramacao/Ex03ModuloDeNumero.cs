using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex03ModuloDeNumero
    {
        public static void Main(String[] args)
        {
            int numero;
            Console.WriteLine("Transforma número inteiro negativo em positivo.");

            Console.WriteLine("\nDigite um número inteiro: ");
            numero = Convert.ToInt16(Console.ReadLine());

            if (numero < 0)
            {
                numero = numero * -1;
                Console.WriteLine("O número transformado em positivo é: " + numero);
            }
        }
    }
}
