using System;

namespace PatterAppProject.PatternCommand
{
    public class FinalizaPedido : ICommand
    {
        private readonly Pedido _pedido;

        public FinalizaPedido(Pedido pedido) => _pedido = pedido;

        public void Executa()
        {
            Console.WriteLine($"Finalizando o pedido do cliente {_pedido.Cliente}");
            _pedido.Finaliza();
        }
    }
}
