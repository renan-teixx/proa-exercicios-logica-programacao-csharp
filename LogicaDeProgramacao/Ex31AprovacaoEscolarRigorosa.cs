using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex31AprovacaoEscolarRigorosa
    {
        public static void Main(String[] args)
        {
            int faltas, n1, n2, n3, media;

            Console.WriteLine("Exibe se você está aprovado ou reprovado com base na sua média e quantidade de faltas.");

            Console.WriteLine("\nDigite a quantidade de faltas que você tem: ");
            faltas = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nDigite a sua 1º nota bimestral: ");
            n1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nDigite a sua 2º nota bimestral: ");
            n2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nDigite a sua 3º nota bimestral: ");
            n3 = Convert.ToInt16(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;

            Console.WriteLine("\nA sua média é: " + media);

            if (media >= 6 && faltas < 15)
            {
                Console.WriteLine("\nAprovado direto");
            }
            else if (media >= 4 && faltas < 15)
            {
                Console.WriteLine("\nRecuperação");
            }
            else
            {
                Console.WriteLine("\nReprovado");
            }
        }
    }
}
