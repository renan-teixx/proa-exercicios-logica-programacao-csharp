using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex28TiposDeTriangulo
    {
        public static void Main(String[] args)
        {

            float a, b, c;

            Console.WriteLine("Determina o tipo de triângulo a partir do tamanho dos seus lados.");

            Console.WriteLine("\nDigite o lado A do triângulo: ");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o lado B do triângulo: ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o lado C do triângulo: ");
            c = float.Parse(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("\nTriângulo equilátero");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("\nTriângulo Isósceles");
            }
            else
            {
                Console.WriteLine("\nTriângulo escaleno");
            }

        }
    }
}
