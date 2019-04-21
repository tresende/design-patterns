using System;

namespace DesignPatterns.Cap6
{
    public class EnviaPorSMS : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando por SMS");
            Console.WriteLine(mensagem.Formata());
        }
    }
}