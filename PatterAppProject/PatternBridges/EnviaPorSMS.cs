using System;

namespace PatterAppProject.PatternBridges
{
    public class EnviaPorSMS : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando mensagem por SMS");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
