using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class EnviadorDeEmail : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("email");
        }
    }
}