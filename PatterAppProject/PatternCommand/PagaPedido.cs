using System;

namespace PatterAppProject.PatternCommand
{
    public class PagaPedido : ICommand
    {
        private readonly Pedido _pedido;

        public PagaPedido(Pedido pedido) => _pedido = pedido;

        public void Executa()
        {
            Console.WriteLine($"Efetuando o pagamento do cliente {_pedido.Cliente}");
            _pedido.Paga();
        }
    }
}
