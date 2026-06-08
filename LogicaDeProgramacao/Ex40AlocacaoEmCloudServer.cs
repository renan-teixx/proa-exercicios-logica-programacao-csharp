using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex40AlocacaoEmCloudServer
    {
        public static void Main(String[] args)
        {
            int vCPU, ram;

            Console.WriteLine("Lê a quantidade de vCPUs e RAM solicitadas para uma nova máquina virtual e categoriza a instância.");

            Console.WriteLine("\nDigite a quantidade de vCPU: ");
            vCPU = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite a quantidade de RAM: ");
            ram = Convert.ToInt32(Console.ReadLine());

            if (vCPU <= 2 && ram <= 4)
            {
                Console.WriteLine("\nInstância Micro");
            }
            else if ((vCPU > 2 && vCPU <= 4) && (ram > 4 && ram <= 8))
            {
                Console.WriteLine("\nInstância Média");
            }
            else if (vCPU > 4 || ram > 8)
            {
                Console.WriteLine("\nNecessário aprovação superior para Instância Larga");
            }
        }
    }
}
