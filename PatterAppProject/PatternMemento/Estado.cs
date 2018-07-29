﻿namespace PatterAppProject.PatternMemento
{
    public class Estado
    {
        public Contrato Contrato { get; private set; }

        public Estado(Contrato contrato) => Contrato = contrato;
    }
}