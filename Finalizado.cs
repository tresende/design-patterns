using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class Finalizado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento finalizados não recebem desconto");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado");
        }
    }
}