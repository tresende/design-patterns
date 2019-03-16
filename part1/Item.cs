using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class Item
    {
        public string Nome { get; private set; }
        public double Valor { get; set; }

        public Item(String nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
    }
}