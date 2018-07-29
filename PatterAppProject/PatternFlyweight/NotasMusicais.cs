using System.Collections.Generic;

namespace PatterAppProject.PatternFlyweight
{
    public class NotasMusicais
    {
        public INotaMusical ObtemNotaMusical(string nota) => notas[nota];

        private static readonly IDictionary<string, INotaMusical> notas =
            new Dictionary<string, INotaMusical>()
            {
                { "do", new Do() },
                { "re", new Re() },
                { "mi", new Mi() },
                { "fa", new Fa() },
                { "sol", new Sol() },
                { "la", new La() },
                { "si", new Si() }
            };
    }
}
