using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex47ArgumentosNomeados
    {
        static void MetodoComArgumentosNomeados(string filho1, string filho2, string filho3) 
        {
            Console.WriteLine("O filho mais novo é: " + filho3);
        }

        public static void Main(String[] args) 
        {
            MetodoComArgumentosNomeados(filho3: "Mary", filho1: "Esther", filho2: "Evelyn");
        }
    }
}
