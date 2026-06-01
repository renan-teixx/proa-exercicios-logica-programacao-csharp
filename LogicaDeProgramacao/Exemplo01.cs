using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Exemplo01
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Programa que calcula a soma de dois números inteiros.");
            
            Console.WriteLine("\nDigite o primeiro número: ");
            int numero1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int numero2 = Convert.ToInt16(Console.ReadLine());

            int soma = numero1 + numero2;

            Console.WriteLine("A soma do número " + numero1 + " com o número " + numero2 + " é: " + soma);
        }
    }
}
