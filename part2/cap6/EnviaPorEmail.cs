using System;

namespace DesignPatterns.Cap6
{
    public class EnviaPorEmail : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando por email");
            Console.WriteLine(mensagem.Formata());
        }
    }
}