using DesignPatterns.Cap4;

namespace DesignPatterns.Cap5
{
   public interface IVisitor
    {
        void ImprimeSoma(Soma soma);
        void ImprimeSubtracao(Subtracao subtracao);
        void ImprimeNumero(Numero numero);
    }
}