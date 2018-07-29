using System.Collections.Generic;

namespace PatterAppProject.PatternCommand
{
    public class FilaDeTrabalho
    {
        private readonly IList<ICommand> commands;

        public FilaDeTrabalho() => commands = commands ?? new List<ICommand>();

        public virtual void Adiciona(ICommand command) => commands.Add(command);

        public virtual void Processa()
        {
            foreach (var item in commands)
                item.Executa();
        }
    }
}
