using DesignPatterns.Cap5;

namespace DesignPatterns.Cap4
{
    public class Soma : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Soma(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = this.Esquerda.Avalia();
            int valorDireita = this.Direita.Avalia();
            return valorEsquerda + valorDireita;
        }

        public void Aceita(IVisitor Impressora)
        {
            Impressora.ImprimeSoma(this);
        }
    }
}