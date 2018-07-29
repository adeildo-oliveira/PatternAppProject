namespace PatterAppProject.PatternBridges
{
    public class MensagemCliente : IMensagem
    {
        private readonly string _nome;

        public IEnviador Enviador { get; set; }

        public MensagemCliente(string nome) => _nome = nome;

        public string Formata() => $"Mensagem para o cliente {_nome}";

        public void Envia() => Enviador.Envia(this);
    }
}
