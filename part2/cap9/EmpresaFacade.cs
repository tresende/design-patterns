using System;

namespace DesignPatterns.Cap9
{
    public class EmpresaFacade
    {
        public Cliente BuscaCliente(string CPF)
        {
            return new ClienteDao().BuscaPorCpf(CPF);
        }

        public Fatura CriaFatura(Cliente cliente, double valor)
        {
            return new Fatura(cliente, valor);
        }

        public Cobranca GeraCobranca(TipoCobranca tipo, Fatura fatura)
        {
            Cobranca cobranca = new Cobranca(tipo, fatura);
            cobranca.Emite();
            return cobranca;
        }

        public ContatoCliente FazContato(Cliente cliente, Cobranca cobranca)
        {
            ContatoCliente contatoCliente = new ContatoCliente(cliente, cobranca);
            contatoCliente.Dispara();
            return contatoCliente;

        }
    }
}