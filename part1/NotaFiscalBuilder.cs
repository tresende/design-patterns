using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        private double valorTotal { get; set; }
        private double impostos { get; set; }
        public string Observacao { get; set; }
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();
        private DateTime data { get; set; }
        private IList<IAcaoAposGerarNota> todasAcoesASeremExecutadas = new List<IAcaoAposGerarNota>();

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacao)
        {
            this.Observacao = observacao;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            this.data = new DateTime();
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilder AdicionaAcao(IAcaoAposGerarNota novaAcao)
        {
            this.todasAcoesASeremExecutadas.Add(novaAcao);
            return this;
        }

        public NotaFiscal Constroi()
        {
            var nf = new NotaFiscal(
                this.RazaoSocial,
                this.Cnpj,
                this.data,
                this.valorTotal,
                this.impostos,
                this.todosItens, "obs");

            foreach (var acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(nf);
            }

            return nf;
        }
    }
}