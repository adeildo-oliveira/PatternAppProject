namespace PatterAppProject.PatternVisitor
{
    public class Numero : IExpressao
    {
        private readonly int _numero;

        public Numero(int numero) => _numero = numero;

        public void Aceita(IVisitor impressora) => impressora.ImprimeNumero(this);

        public int Avalia() => _numero;
    }
}
