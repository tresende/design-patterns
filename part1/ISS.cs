namespace DesignPatterns
{
    public class ISS : Imposto
    {
        public ISS() : base() { }
        public ISS(Imposto outroImposto) : base(outroImposto) { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + base.CalculoDoOutroImposto(orcamento);
        }
    }
}