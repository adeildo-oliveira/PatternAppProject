using System;

namespace PatterAppProject.PatternInterpreter
{
    public class RaizQuadrada : IExpressao
    {
        private readonly IExpressao _raizQuadrada;

        public RaizQuadrada(IExpressao raizQuadrada) => _raizQuadrada = raizQuadrada;

        public int Avalia() => (int)Math.Sqrt(_raizQuadrada.Avalia());
    }
}
