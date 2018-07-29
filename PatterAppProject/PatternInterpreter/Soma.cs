namespace PatterAppProject.PatternInterpreter
{
    public class Soma : IExpressao
    {
        private readonly IExpressao _esquerda;
        private readonly IExpressao _direita;

        public Soma(IExpressao esquerda, IExpressao direita)
        {
            _esquerda = esquerda;
            _direita = direita;
        }

        public int Avalia()
        {
            var resultadoDaEsquerda = _esquerda.Avalia();
            var resultadoDaDireita = _direita.Avalia();

            return resultadoDaEsquerda + resultadoDaDireita;
        }
    }
}
