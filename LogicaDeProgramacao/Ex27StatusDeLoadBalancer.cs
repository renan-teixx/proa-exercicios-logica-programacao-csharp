using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex27StatusDeLoadBalancer
    {
        public static void Main(String[] args)
        {

            int cargaProcessamento;

            Console.WriteLine("Mostra o status atual um cluster.");

            Console.WriteLine("\nDigite a porcentagem de processamento do cluster: ");
            cargaProcessamento = Convert.ToInt16(Console.ReadLine());

            if (cargaProcessamento <= 40)
            {
                Console.WriteLine("\nOcioso");
            }
            else if (cargaProcessamento <= 70)
            {
                Console.WriteLine("\nEstável");
            }
            else if (cargaProcessamento <= 90)
            {
                Console.WriteLine("\nAtenção");
            }
            else 
            { 
                Console.WriteLine("\nCrítico - escalar novo nó"); 
            }
        }
    }
}
