using System;

namespace DesignPatterns
{
    public class Orcamento
    {
        public double Valor {get; private set;}

        public Orcamento(){}
        public Orcamento(double valor)
        {
            this.Valor = valor;
        }
    }
}
