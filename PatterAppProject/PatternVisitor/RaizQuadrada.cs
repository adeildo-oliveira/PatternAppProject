using System;

namespace PatterAppProject.PatternVisitor
{
    public class RaizQuadrada : IExpressao
    {
        private readonly IExpressao _raizQuadrada;

        public RaizQuadrada(IExpressao raizQuadrada) => _raizQuadrada = raizQuadrada;

        public void Aceita(IVisitor impressora) => throw new NotImplementedException();

        public int Avalia() => (int)Math.Sqrt(_raizQuadrada.Avalia());
    }
}
