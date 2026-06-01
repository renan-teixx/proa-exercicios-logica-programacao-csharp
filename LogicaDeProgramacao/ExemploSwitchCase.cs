using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class ExemploSwitchCase
    {
        public static void Main(String[] args)
        {
            int numero;

            Console.WriteLine("Exemplo de Switch Case.");

            Console.WriteLine("\nDigite um valor númerico entre 1 e 7:");
            numero = Convert.ToInt16(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("\nDomingo");
                    break;
                case 2:
                    Console.WriteLine("\nSegunda");
                    break;
                case 3:
                    Console.WriteLine("\nTerça");
                    break;
                case 4:
                    Console.WriteLine("\nQuarta");
                    break;
                case 5:
                    Console.WriteLine("\nQuinta");
                    break;
                case 6:
                    Console.WriteLine("\nSexta");
                    break;
                case 7:
                    Console.WriteLine("\nSábado");
                    break;
                default:
                    Console.WriteLine("\nDia inexistente.");
                    break;
            }
        }
    }
}
