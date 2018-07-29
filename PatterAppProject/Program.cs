using PatterAppProject.PatternAdapter;
using System;

namespace PatterAppProject
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Factory
            //using (var conexao = new ConnectionFactory().GetConnection())
            //{
            //    using (var command = conexao.CreateCommand())
            //        command.CommandText = "select * from tabela";
            //}
            #endregion

            #region Flyweight
            //var notasMusicais = new NotasMusicais();
            //var doReMiFa = new List<INotaMusical>()
            //{
            //    notasMusicais.ObtemNotaMusical("do"),
            //    notasMusicais.ObtemNotaMusical("re"),
            //    notasMusicais.ObtemNotaMusical("mi"),
            //    notasMusicais.ObtemNotaMusical("fa"),
            //    notasMusicais.ObtemNotaMusical("fa"),
            //    notasMusicais.ObtemNotaMusical("fa")
            //};

            //var piano = new Piano();
            //piano.Toca(doReMiFa);
            #endregion

            #region Memento
            //var historico = new Historico();
            //var contrato = new Contrato("Mauricio", DateTime.Now, TipoContrato.Novo);
            //historico.Adiciona(contrato.SalvaEstado());

            //contrato.Avanca();
            //historico.Adiciona(contrato.SalvaEstado());

            //contrato.Avanca();
            //historico.Adiciona(contrato.SalvaEstado());

            //contrato.Avanca();
            //historico.Adiciona(contrato.SalvaEstado());
            #endregion

            #region Interpreter
            //IExpressao esquerda = new Subtracao(new Numero(10), new Numero(5));
            //IExpressao direita = new Soma(new Numero(2), new Numero(10));
            //IExpressao conta = new Soma(esquerda, direita);

            //IExpressao multiplicao = new Multiplicacao(new Numero(2), new Numero(10));
            //IExpressao divisao = new Divisao(new Numero(2), new Numero(10));
            //IExpressao raiz = new RaizQuadrada(new Numero(125));

            //Console.WriteLine($"Resultado soma: {direita.Avalia()}");
            //Console.WriteLine($"Resultado subtração: {esquerda.Avalia()}");
            //Console.WriteLine($"Resultado soma total: {conta.Avalia()}");
            //Console.WriteLine($"Resultado soma multiplicação: {multiplicao.Avalia()}");
            //Console.WriteLine($"Resultado soma divisão: {divisao.Avalia()}");
            //Console.WriteLine($"Resultado soma raiz quadrada: {raiz.Avalia()}");
            #endregion

            #region Visitor
            //IExpressao esquerda = new Subtracao(new Numero(10), new Numero(5));
            //IExpressao direita = new Soma(new Numero(2), new Numero(10));
            //IExpressao conta = new Soma(esquerda, direita);
            //var visitor = new ImpressoraVisitor();
            //conta.Aceita(visitor);
            #endregion

            #region Bridges
            //IMensagem mensagem = new MensagemCliente("victor");
            //mensagem.Enviador = new EnviaPorEmail();
            //mensagem.Envia();
            #endregion

            #region Command
            //var pedido1 = new Pedido("Mauricio", 150.0M);
            //var pedido2 = new Pedido("Marcelo", 250.0M);
            //var fila = new FilaDeTrabalho();

            //fila.Adiciona(new PagaPedido(pedido1));
            //fila.Adiciona(new PagaPedido(pedido2));
            //fila.Adiciona(new FinalizaPedido(pedido1));

            //fila.Processa();
            #endregion

            #region Adapter
            var cliente = new Cliente
            {
                Nome = "victor",
                Endereco = "Rua Vergueiro",
                DataDeNascimento = DateTime.Now
            };

            var xml = new GeradorDeXml<Cliente>().GeraXml(cliente);
            Console.WriteLine(xml);
            #endregion

            Console.ReadKey();
        }
    }
}
