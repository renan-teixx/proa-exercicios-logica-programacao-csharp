using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex01ValidacaoDeNota
    {
        public static void Main(String[] args)
        {

            float nota;

            Console.WriteLine("Validação de nota na matéria de Cálculo 1.");

            Console.WriteLine("\nDigite a sua nota: ");
            nota = float.Parse(Console.ReadLine());

            if (nota >= 6)
            {
                Console.WriteLine("\nAprovado");
            }

        }
    }
}
