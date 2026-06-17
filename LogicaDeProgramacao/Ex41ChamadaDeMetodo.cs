using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex41ChamadaDeMetodo
    {
        static void MetodoParaExibirMensagem()
        {
            Console.WriteLine("Essa mensagem deve ser exibida ao chamar o método!");
        }

        public static void Main(String[] args)
        {
            MetodoParaExibirMensagem();
        }
    }
}
