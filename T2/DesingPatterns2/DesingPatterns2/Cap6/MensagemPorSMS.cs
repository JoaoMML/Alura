using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns2.Cap6
{
    class MensagemPorSMS : IMensagem
    {
        private string nome;

        public MensagemPorSMS(string nome)
        {
            this.nome = nome;
        }
        public void Envia()
        {
            Console.WriteLine("Enviando a mensagem por SMS");
            Console.WriteLine("Mensagem para o cliente {0}", nome);
        }
    }
}
