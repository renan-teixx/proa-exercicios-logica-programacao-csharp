using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    internal class Ex42ChamadaMultiplaDeMetodo
    {
        static void MetodoParaExibirMultiplasMensagens()
        {
            Console.WriteLine("Essa mensagem deve ser exibida ao chamar o método!");
        }

        public static void Main(String[] args)
        {
            MetodoParaExibirMultiplasMensagens();
            MetodoParaExibirMultiplasMensagens();
            MetodoParaExibirMultiplasMensagens();
        }
    }
}
