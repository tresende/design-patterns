namespace DesignPatterns.Cap4
{
    public class Numero : IExpressao
    {
        public int numero { get; set; }

        public Numero(int numero)
        {
            this.numero = numero;
        }

        public int Avalia()
        {
            return this.numero;
        }
    }
}