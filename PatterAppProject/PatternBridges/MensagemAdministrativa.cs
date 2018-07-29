namespace PatterAppProject.PatternBridges
{
    public class MensagemAdministrativa : IMensagem
    {
        private readonly string _nome;

        public IEnviador Enviador { get; set; }

        public MensagemAdministrativa(string nome) => _nome = nome;

        public string Formata() => $"Mensagem administrativa para {_nome}";

        public void Envia() => Enviador.Envia(this);
    }
}
