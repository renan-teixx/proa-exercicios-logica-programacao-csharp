using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex23IdentificacaoDePortasDeRedecs
    {
        public static void Main(String[] args)
        {

            int porta;

            Console.WriteLine("Apresenta a porta de rede dependendo do número da porta digitado.");

            Console.WriteLine("\nDigite o número da porta de rede: ");
            porta = Convert.ToInt32(Console.ReadLine());

            if (porta == 80)
            {
                Console.WriteLine("\nHTTP");
            }
            else if (porta == 443)
            {
                Console.WriteLine("\nHTTPS");
            }
            else if (porta == 22)
            {
                Console.WriteLine("\nSSH");
            }
            else
            {
                Console.WriteLine("\nServiço desconhecido ou não padrão");
            }
        }
    }
}
