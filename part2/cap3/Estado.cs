using System;

namespace DesignPatterns.Cap3
{
    public class Estado
    {
        public Contrato Contrato { get; private set; }
        
        public Estado(Contrato contrato)
        { 
            this.Contrato = contrato;
        }
    }
}