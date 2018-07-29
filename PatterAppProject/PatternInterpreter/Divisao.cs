namespace PatterAppProject.PatternInterpreter
{
    public class Divisao : IExpressao
    {
        private readonly IExpressao _esquerda;
        private readonly IExpressao _direita;

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            _esquerda = esquerda;
            _direita = direita;
        }

        public int Avalia() => _esquerda.Avalia() / _direita.Avalia();
    }
}
