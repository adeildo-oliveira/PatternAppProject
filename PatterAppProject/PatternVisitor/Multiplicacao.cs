namespace PatterAppProject.PatternVisitor
{
    public class Multiplicacao : IExpressao
    {
        private readonly IExpressao _esquerda;
        private readonly IExpressao _direita;

        public Multiplicacao(IExpressao esquerda, IExpressao direita)
        {
            _esquerda = esquerda;
            _direita = direita;
        }

        public void Aceita(IVisitor impressora) => throw new System.NotImplementedException();

        public int Avalia() => _esquerda.Avalia() * _direita.Avalia();
    }
}
