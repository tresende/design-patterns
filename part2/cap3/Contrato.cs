using System;

namespace DesignPatterns.Cap3
{
    public class Contrato
    {
        public DateTime Data { get; private set; }
        public string Cliente { get; private set; }
        public TipoContrato Tipo { get; private set; }

        public Contrato(DateTime data, string cliente, TipoContrato tipo)
        {
            this.Data = data;
            this.Cliente = cliente;
            this.Tipo = tipo;
        }

        public void Avanca()
        {
            if (this.Tipo == TipoContrato.Novo)
            {
                this.Tipo = TipoContrato.EmAndamaento;
            }
            else if (this.Tipo == TipoContrato.EmAndamaento)
            {
                this.Tipo = TipoContrato.Acertado;
            }
            else if (this.Tipo == TipoContrato.Acertado)
            {
                this.Tipo = TipoContrato.Concluido;
            }
        }

        public Estado SalvaEstado()
        {
            Contrato contrato = new Contrato(this.Data, this.Cliente, this.Tipo);
            return new Estado(contrato);
        }
    }
}