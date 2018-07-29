using System;

namespace PatterAppProject.PatternMemento
{
    public class Contrato
    {
        public string NomeCliente { get; private set; }
        public DateTime Data { get; private set; }
        public TipoContrato Tipo { get; private set; }

        public Contrato(string nome, DateTime data, TipoContrato tipoContrato)
        {
            NomeCliente = nome;
            Data = data;
            Tipo = tipoContrato;
        }

        public void Avanca()
        {
            if (Tipo == TipoContrato.Novo) Tipo = TipoContrato.EmAndamento;
            else if (Tipo == TipoContrato.EmAndamento) Tipo = TipoContrato.Acertado;
            else if (Tipo == TipoContrato.Acertado) Tipo = TipoContrato.Concluido;
        }

        public Estado SalvaEstado() => new Estado(new Contrato(NomeCliente, Data, Tipo));
    }
}
