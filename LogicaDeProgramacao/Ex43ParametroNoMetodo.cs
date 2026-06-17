using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex43ParametroNoMetodo
    {
        static void MetodoComParametro(string nome)
        {
            Console.WriteLine(nome + " Silva");
        }

        public static void Main(String[] args)
        {
            MetodoComParametro("Esther");
            MetodoComParametro("Mary");
            MetodoComParametro("Evelyn");
        }
    }
}
