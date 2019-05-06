using System;
using System.Collections.Generic;

namespace DesignPatterns.Cap7
{
    public class FinalizaPedido : IComando
    {
        public FinalizaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        private Pedido pedido;
        public void Executa()
        {
            Console.WriteLine("Finalizando o pedido do cliente {0}", pedido.Cliente);
            this.pedido.Finaliza();
        }
    }
}