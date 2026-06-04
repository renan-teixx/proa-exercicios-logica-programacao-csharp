using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex30MultaDeTransito
    {
        public static void Main(String[] args)
        {

            float velocidadeVia, velocidadeVeiculo;

            Console.WriteLine("Determina a gravidade da infração de trânsito.");

            Console.WriteLine("\nDigite o limite de velocidade da via: ");
            velocidadeVia = float.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a velocidade do seu veículo nessa via: ");
            velocidadeVeiculo = float.Parse(Console.ReadLine());

            if (velocidadeVeiculo <= velocidadeVia)
            {
                Console.WriteLine("\nSem multa");
            }
            else if (velocidadeVeiculo <= velocidadeVia + (20f / 100 * velocidadeVia))
            {
                Console.WriteLine("\nMulta média");
            }
            else if (velocidadeVeiculo <= velocidadeVia + (50f / 100 * velocidadeVia))
            {
                Console.WriteLine("\nMulta grave");
            }
            else 
            {
                Console.WriteLine("\nMulta gravíssima");
            }

        }
    }
}
