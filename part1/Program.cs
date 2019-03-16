using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var criador = new NotaFiscalBuilder()
                              .ParaEmpresa("Caelum")
                              .ComCnpj("123.456.789/0001-10")
                              .ComItem(new ItemDaNota("item 1", 100.0))
                              .ComItem(new ItemDaNota("item 2", 200.0))
                              .ComItem(new ItemDaNota("item 3", 300.0))
                              .ComObservacoes("entregar nf pessoalmente")
                              .NaDataAtual()
                              .AdicionaAcao(new EnviadorDeEmail())
                              .AdicionaAcao(new NotaFiscalDao())
                              .AdicionaAcao(new EnviadorDeSms());
            var nf = criador.Constroi();
        }

        static void Builder()
        {
            IList<ItemDaNota> itens = new List<ItemDaNota>();
            double valorTotal = 0;
            foreach (var item in itens)
            {
                valorTotal += item.Valor;
            }
            double impostos = valorTotal * 0.05;
            NotaFiscal nf = new NotaFiscal("razao", "cnpj", DateTime.Now, valorTotal, impostos, itens, "obs");

            NotaFiscal nf2 = new NotaFiscalBuilder()
                              .ParaEmpresa("Caelum")
                              .ComCnpj("123.456.789/0001-10")
                              .ComItem(new ItemDaNota("item 1", 100.0))
                              .ComItem(new ItemDaNota("item 2", 200.0))
                              .ComItem(new ItemDaNota("item 3", 300.0))
                              .ComObservacoes("entregar nf pessoalmente")
                              .NaDataAtual()
                              .Constroi();
        }

        static void State()
        {
            Orcamento orcamento = new Orcamento(500);
            orcamento.AplicaDescontoExtra();
            System.Console.WriteLine(orcamento.Valor);

            orcamento.Aprova();
            orcamento.AplicaDescontoExtra();
            System.Console.WriteLine(orcamento.Valor);

            orcamento.Finaliza();
            System.Console.WriteLine(orcamento.Valor);
        }

        static void DecorationPattern()
        {
            Imposto iss = new ICMS(new ISS());
            Orcamento orcamento = new Orcamento(500);
            var valor = iss.Calcula(orcamento);
            System.Console.WriteLine(valor);
        }

        static void TemplateMethod()
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();
            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("Caneta", 250));
            orcamento.AdicionaItem(new Item("Lápis", 250));
            orcamento.AdicionaItem(new Item("Geladeira", 250));
            orcamento.AdicionaItem(new Item("Microondas", 250));
            orcamento.AdicionaItem(new Item("xbox", 250));
            orcamento.AdicionaItem(new Item("mouse", 250));
            double desconto = calculador.Calcula(orcamento);
            System.Console.WriteLine(desconto);
        }

        static void Strategy()
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(50);
            var calculadora = new CalculadorDeImpostos();

            calculadora.RealizaCalculo(orcamento, iss);
            calculadora.RealizaCalculo(orcamento, icms);
        }
    }
}
