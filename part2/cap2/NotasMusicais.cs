using System.Collections.Generic;

namespace DesignPatterns.Cap2
{
    public class NotasMusicais
    {
        private static IDictionary<string, INota> Notas =
         new Dictionary<string, INota>()
         {
             { "do", new Do() },
             { "re", new Re() },
             { "mi", new Mi() },
             { "fa", new Fa() },
             { "sol", new Sol() },
             { "la", new La() },
             { "si", new Si() }
         };

        public INota GetNota(string nome)
        {
            return Notas[nome];
        }
    }
}