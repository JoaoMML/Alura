using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns2.Cap6
{
    class MensagemAdm : IMensagem
    {
        private string nome;
        public IEnviador Enviador { get; set; }


        public MensagemAdm(string nome)
        {
            this.nome = nome;
        }
        public void Envia()
        {
            this.Enviador.Envia(this); 
        }
        public string Formata()
        {
            return string.Format("Enviando a mensagem para o administrador {0}", nome);
        }
    }
}
