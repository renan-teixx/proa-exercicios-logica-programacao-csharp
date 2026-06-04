using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex17DiferencaAbsoluta
    {
        public static void Main(String[] args)
        {

            int a, b, resultado;

            Console.WriteLine("Exibe o resultado da subtração de dois números.");

            Console.WriteLine("\nDigite o primeiro número: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite o segundo número: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {

                resultado = a - b;
                Console.WriteLine("\nO resultado é: " + resultado);

            }
            else
            {

                resultado = b - a;
                Console.WriteLine("\nO resultado é: " + resultado);

            }

        }
    }
}
