namespace DesignPatterns
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }

        public Imposto() { }

        public Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        public abstract double Calcula(Orcamento orcamento);

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if (this.OutroImposto == null) return 0;
            
            return OutroImposto.Calcula(orcamento);
        }
    }
}