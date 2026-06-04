using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex12LatenciaDeRede
    {
        public static void Main(String[] args)
        {

            int tempoResposta;

            Console.WriteLine("Verifica se a sua conexão está estável ou não.");

            Console.WriteLine("\nDigite o valor em milissegundos do seu último ping: ");
            tempoResposta = Convert.ToInt16(Console.ReadLine());

            if (tempoResposta < 100)
            {
                Console.WriteLine("\nConexão estável");
            }
            else
            {
                Console.WriteLine("\nConexão lenta");
            }

        }
    }
}
