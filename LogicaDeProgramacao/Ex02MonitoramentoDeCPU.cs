using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex02MonitoramentoDeCPU
    {
        public static void Main(String[] args) 
        {
            int taxaUsoCPU;

            Console.WriteLine("Lê a taxa de uso da cpu de um servidor em porcentagem.");

            Console.WriteLine("\nDigite quantos % está a taxa de uso da cpu: ");
            taxaUsoCPU = Convert.ToInt16(Console.ReadLine());

            if (taxaUsoCPU > 85)
            {
                Console.WriteLine("\nAlerta: Sobrecarga no servidor.");
            }
        
        }
    }
}
