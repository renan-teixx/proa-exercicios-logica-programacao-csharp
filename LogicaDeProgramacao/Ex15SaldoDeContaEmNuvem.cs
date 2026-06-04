using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex15SaldoDeContaEmNuvem
    {
        public static void Main(String[] args)
        {

            int saldoCreditos;

            Console.WriteLine("Mostra se os serviços da conta AWS estão ativos baseado nos seus créditos.");

            Console.WriteLine("\nDigite o seu saldo de créditos: ");
            saldoCreditos = Convert.ToInt16(Console.ReadLine());

            if (saldoCreditos < 0)
            {
                Console.WriteLine("\nServiços suspensos");
            }
            else
            {
                Console.WriteLine("\nServiços ativos");
            }
        }
    }
}
