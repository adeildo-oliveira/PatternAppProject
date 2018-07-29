using System;

namespace PatterAppProject.PatternBridges
{
    public class EnviaPorEmail : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando mensagem por e-mail");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
