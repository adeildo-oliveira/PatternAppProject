using System;
using System.Collections.Generic;

namespace PatterAppProject.PatternFlyweight
{
    public class Piano
    {
        public void Toca(IList<INotaMusical> musica)
        {
            foreach (var nota in musica)
                Console.Beep(nota.Frequencia, 300);
        }
    }
}
