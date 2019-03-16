using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class NotaFiscalDao: IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("bd");
        }
    }
}