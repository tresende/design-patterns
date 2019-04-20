using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Data.SqlClient;
using DesignPatterns.Cap1;
using DesignPatterns.Cap2;
using DesignPatterns.Cap3;
using DesignPatterns.Cap4;
using DesignPatterns.Cap5;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        { 
            
        }

        static void VisitorPattern()
        {
            IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            var conta = new Soma(esquerda, direita);
            System.Console.WriteLine(conta.Avalia());
            ImpressoraVisitor impressora = new ImpressoraVisitor();
            conta.Aceita(impressora);
        }

        static void InterpreterPattern(string[] args){
            Expression soma = Expression.Add(Expression.Constant(10), Expression.Constant(100));
            Func<int> interpreter = Expression.Lambda<Func<int>>(soma).Compile();
            int resultado = interpreter();
            
        }

        static void Memento(string[] args)
        {
            Historico historico = new Historico();
            Contrato contrato = new Contrato(DateTime.Now, "Thiago", TipoContrato.Novo);
            historico.Adiciona(contrato.SalvaEstado());
            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());
            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());
            System.Console.WriteLine(contrato.Tipo);
            System.Console.WriteLine(historico.Get(2).Contrato.Tipo);
        }

        static void Flyweight(string[] args)
        {
            var notasMusicais = new NotasMusicais();
            var musica = new List<INota>()
            {
                notasMusicais.GetNota("do"),
                notasMusicais.GetNota("re"),
                notasMusicais.GetNota("mi"),
                notasMusicais.GetNota("fa"),
                notasMusicais.GetNota("fa"),
                notasMusicais.GetNota("fa"),
            };
            Piano piano = new Piano();
            piano.Toca(musica);
        }

        static void Factory()
        {
            IDbConnection conexao = new ConnectionFactory().GetConnection();
            conexao.CreateCommand();
            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from tabela;";
        }
    }
}