using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class ItemDaNota
    {
        public ItemDaNota(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }

        public string Nome { get; set; }
        public double Valor { get; set; }
    }
}