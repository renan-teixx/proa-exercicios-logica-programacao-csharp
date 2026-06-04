using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex13FrequenciaAcademica
    {
        public static void Main(String[] args)
        {

            int quantidadeFaltas;

            Console.WriteLine("Verifica sua frequência no curso e diz a sua situação atual.");

            Console.WriteLine("\nDigite o seu número de faltas: ");
            quantidadeFaltas = Convert.ToInt16(Console.ReadLine());

            if (quantidadeFaltas > 15)
            {
                Console.WriteLine("\nReprovado por faltas");
            }
            else
            { 
                Console.WriteLine("\nFrequência dentro do limite");
            }
        }
    }
}
