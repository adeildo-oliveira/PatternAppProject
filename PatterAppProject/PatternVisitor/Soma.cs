namespace PatterAppProject.PatternVisitor
{
    public class Soma : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Soma(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public void Aceita(IVisitor impressora) => impressora.ImprimeSoma(this);

        public int Avalia()
        {
            var resultadoDaEsquerda = Esquerda.Avalia();
            var resultadoDaDireita = Direita.Avalia();

            return resultadoDaEsquerda + resultadoDaDireita;
        }
    }
}
