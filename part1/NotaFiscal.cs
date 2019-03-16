using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class NotaFiscal
    {
        public NotaFiscal(string razaoSocial,
                          string cnpj,
                          DateTime dataEmissao,
                          double valorBruto,
                          double impostos,
                          IList<ItemDaNota> itens,
                          string observacoes)
        {
            this.RazaoFiscal = razaoSocial;
            this.Cnpj = cnpj;
            this.DataEmissao = dataEmissao;
            this.ValorBruto = valorBruto;
            this.Itens = itens;
            this.Observacoes = observacoes;
        }

        public string RazaoFiscal { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public string Observacoes { get; set; }
        public IList<ItemDaNota> Itens { get; set; }
    }
}