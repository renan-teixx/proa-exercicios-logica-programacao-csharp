using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex04VerificacaoDeRepouso
    {
        public static void Main(String[] args)
        {
            int horasEstudo;
            Console.WriteLine("Verfifica para o aluno se é necessário fazer um repouso dos estudos.");

            Console.WriteLine("\nDigite quantas horas você estudou hoje: ");
            horasEstudo = Convert.ToInt16(Console.ReadLine());

            if (horasEstudo > 10)
            {
                Console.WriteLine("\nAviso: Necessário intervalo para descanso.");
            }
        }
    }
}
