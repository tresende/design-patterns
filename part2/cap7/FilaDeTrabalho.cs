using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPatterns.Cap7
{
    public class FilaDeTrabalho
    {
        private IList<IComando> comandos = new List<IComando>();

        public void Adicona(IComando comando)
        {
            this.comandos.Add(comando);
        }

        public void Processa()
        {
            foreach (var comando in this.comandos)
            {
                comando.Executa();
                Thread.Sleep(1000);
            }
        }
    }
}