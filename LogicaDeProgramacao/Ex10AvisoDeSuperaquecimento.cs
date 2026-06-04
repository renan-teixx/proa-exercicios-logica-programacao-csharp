using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex10AvisoDeSuperaquecimento
    {
        public static void Main(String[] args)
        {
            int temperatura;

            Console.WriteLine("Alerta se há superaquecimento no roteador.");

            Console.WriteLine("\nDigite a temperatura (em Celsius)");
            temperatura = Convert.ToInt16(Console.ReadLine());

            if (temperatura > 75) 
            {
                Console.WriteLine("\nAlerta de superaquecimento de hardware");
            }
        }
    }
}
