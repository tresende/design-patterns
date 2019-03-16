using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

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