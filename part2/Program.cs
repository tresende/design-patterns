using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DesignPatterns.Cap1;
using DesignPatterns.Cap2;
using DesignPatterns.Cap3;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        { }
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