namespace DesignPatterns.Cap6
{
    public class MensagemCliente : IMensagem
    {
        private string nome { get; set; }
        public IEnviador Enviador { get; set; }

        public MensagemCliente(string nome) => this.nome = nome;

        public void Envia() => this.Enviador.Envia(this);

        public string Formata() => string.Format("Mensagem para o administrador {0}", this.nome);
    }
}