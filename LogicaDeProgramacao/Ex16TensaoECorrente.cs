using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex16TensaoECorrente
    {
        public static void Main(String[] args)
        {

            int tensao, corrente, potencia;

            Console.WriteLine("Calcula a potencia de um equipamento.");

            Console.WriteLine("\nDigite a tensão do equipamento: ");
            tensao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite a corrente do equipamento: ");
            corrente= Convert.ToInt32(Console.ReadLine());

            potencia = tensao * corrente;

            if (potencia > 1000)
            {
                Console.WriteLine("\nEquipamento de alta potência");
            }
            else
            { 
                Console.WriteLine("\nEquipamento de baixa potência");
            }

        }
    }
}
