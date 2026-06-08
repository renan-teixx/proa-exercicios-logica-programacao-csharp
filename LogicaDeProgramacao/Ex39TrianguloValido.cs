using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex39TrianguloValido
    {
        public static void Main(String[] args) 
        {
            float a, b, c;

            Console.WriteLine("Verifica se os 3 valores de retas digitadas podem formar um triângulo ou não.");

            Console.WriteLine("\nDigite o valor de A: ");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o valor de B: ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o valor de C: ");
            c = float.Parse(Console.ReadLine());

            if (a < b + c && b < a + c && c < a + b)
            {
                Console.WriteLine("\nForma um triângulo");
            }
            else 
            { 
                Console.WriteLine("\nNão forma um triângulo");
            }
        }
    }
}
