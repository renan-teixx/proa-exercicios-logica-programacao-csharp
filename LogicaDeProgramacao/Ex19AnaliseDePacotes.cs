using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex19AnaliseDePacotes
    {
        public static void Main(String[] args)
        {

            int quantidadePacotesPerdidos;

            Console.WriteLine("Verifica se houve perda de pacotes durante a transmissão.");

            Console.WriteLine("\nDigite a quantidade de pacotes perdidos: ");
            quantidadePacotesPerdidos = Convert.ToInt32(Console.ReadLine());

            if (quantidadePacotesPerdidos > 0)
            {

                Console.WriteLine("\nTransmissão com perdas");
            }
            else
            {
                Console.WriteLine("\nTransmissão perfeita");
            }
        }
    }
}
