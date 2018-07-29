using System;

namespace PatterAppProject.PatternCommand
{
    public class Pedido
    {
        public string Cliente { get; private set; }
        public decimal Valor { get; private set; }
        public Status Status { get; private set; }
        public DateTime DataFinalizacao { get; private set; }

        public Pedido(string cliente, decimal valor)
        {
            Cliente = cliente;
            Valor = valor;
            Status = Status.Novo;
        }

        public void Paga() => Status = Status.Pago;

        public void Finaliza()
        {
            DataFinalizacao = DateTime.Now;
            Status = Status.Entregue;
        }
    }
}
