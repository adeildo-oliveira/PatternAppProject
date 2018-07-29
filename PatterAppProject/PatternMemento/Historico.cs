using System.Collections.Generic;

namespace PatterAppProject.PatternMemento
{
    public class Historico
    {
        private IList<Estado> Estados;

        public Historico() => Estados = new List<Estado>();

        public Estado Pega(int index) => Estados[index];

        public void Adiciona(Estado estado) => Estados.Add(estado);
    }
}
