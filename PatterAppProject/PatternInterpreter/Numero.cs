namespace PatterAppProject.PatternInterpreter
{
    public class Numero : IExpressao
    {
        private readonly int _numero;

        public Numero(int numero) => _numero = numero;

        public int Avalia() => _numero;
    }
}
