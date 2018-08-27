using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns2.Cap6
{
    class MensagemCliente : IMensagem
    {
        private string nome;
        public IEnviador Enviador { get; set; }

        public MensagemCliente(string nome)
        {
            this.nome = nome;
        }
        public void Envia()
        {
            this.Enviador.Envia(this);
        }
        public string Formata()
        {
            return string.Format("Enviando a mensagem para o cliente {0}", nome);
        }
    }
}
