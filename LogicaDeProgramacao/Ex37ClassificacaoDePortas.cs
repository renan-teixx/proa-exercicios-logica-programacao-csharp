using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex37ClassificacaoDePortas
    {
        public static void Main(String[] args)
        {
            int porta;

            Console.WriteLine("Verifica se a porta digitada existe ou não.");

            Console.WriteLine("\nDigite o número da porta: ");
            porta = Convert.ToInt32(Console.ReadLine());

            if (porta < 0 || porta > 65535)
            {
                Console.WriteLine("\nPorta inválida");
            }
            else if (porta <= 1023)
            {
                Console.WriteLine("\nPortas conhecidas");
            }
            else if (porta <= 49151)
            {
                Console.WriteLine("\nPortas registradas");
            }
            else 
            {
                Console.WriteLine("\nPortas dinâmicas");
            }
        }
    }
}
