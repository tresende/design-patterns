using System;
using System.Threading;
using System.Collections.Generic;

namespace DesignPatterns.Cap7
{
    public class PagaPedido : IComando
    {
        public PagaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        private Pedido pedido;
        public void Executa()
        {
            Console.WriteLine("Pagando o pedido do cliente {0}", pedido.Cliente);
            this.pedido.Paga();
        }
    }
}