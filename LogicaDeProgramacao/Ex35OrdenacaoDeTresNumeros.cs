using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex35OrdenacaoDeTresNumeros
    {
        public static void Main(String[] args)
        {
            int a, b, c;

            Console.WriteLine("Mostra três números inteiros em ordem crescente.");
            
            Console.WriteLine("\nDigite o primeiro número (A): ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite o segundo número (B): ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite o terceiro número (C): ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nA ordem crescente é: ");
            if (a <= b && b <= c)
            {
                Console.WriteLine(a + " " + b + " " + c);
            }
            else if (a <= c && c <= b)
            {
                Console.WriteLine(a + " " + c + " " + b);
            }
            else if (b <= a && a <= c)
            {
                Console.WriteLine(b + " " + a + " " + c);
            }
            else if (b <= c && c <= a)
            {
                Console.WriteLine(b + " " + c + " " + a);
            }
            else if (c <= a && a <= b)
            {
                Console.WriteLine(c + " " + a + " " + b);
            }
            else if (c <= b && b <= a)
            {
                Console.WriteLine(c + " " + b + " " + a);
            }
        }
    }
}
