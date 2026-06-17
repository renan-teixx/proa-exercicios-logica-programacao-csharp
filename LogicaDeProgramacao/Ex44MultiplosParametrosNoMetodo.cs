using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex44MultiplosParametrosNoMetodo
    {
        static void MetodoComMultiplosParametros(string nome, int idade)
        {
            Console.WriteLine(nome + " tem " + idade + " anos.");
        }

        public static void Main(String[] args) 
        {
            MetodoComMultiplosParametros("Esther", 23);
            MetodoComMultiplosParametros("Mary", 20);
            MetodoComMultiplosParametros("Evelyn", 22);
        }
    }
}
