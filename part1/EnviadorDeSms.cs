using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class EnviadorDeSms: IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("sms");
        }
    }
}