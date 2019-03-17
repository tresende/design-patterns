using System.Collections.Generic;

namespace DesignPatterns.Cap3
{
    public class Historico
    {
        public IList<Estado> Estados = new List<Estado>();

        public void Adiciona(Estado estado)
        {
            this.Estados.Add(estado);
        }

        public Estado Get(int indice)
        {
            return this.Estados[indice];
        }
    }
}