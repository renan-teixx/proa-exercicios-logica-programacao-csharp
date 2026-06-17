using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex45ParametroDefault
    {
        static void MetodoComParametroDefault(string pais = "Brasil") 
        {
            Console.WriteLine(pais);
        }

        public static void Main(String[] args) 
        {
            MetodoComParametroDefault("Argentina");
            MetodoComParametroDefault("França");
            MetodoComParametroDefault("Espanha");
            MetodoComParametroDefault();
        }
    }
}
