using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex11MaiorValor
    {
        public static void Main(String[] args)
        {

            float numero1, numero2;

            Console.WriteLine("Mostra qual é o maior de dois números reais digitados.");

            Console.WriteLine("\nDigite o primeiro numero: ");
            numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o segundo numero: ");
            numero2 = float.Parse(Console.ReadLine());
          
            if (numero1 > numero2)
            {
                Console.WriteLine("\nO maior número é: " + numero1);
            }
            else {
                Console.WriteLine("\nO maior número é: " + numero2);
            }

        }
    }
}
