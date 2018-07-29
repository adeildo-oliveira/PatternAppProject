namespace PatterAppProject.PatternVisitor
{
    public interface IExpressao
    {
        int Avalia();
        void Aceita(IVisitor impressora);
    }
}
