using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Cliente
    {
        public string nome { get; set; }
        public string rg { get; set; }
        public string endereco { get; set; }
        public string cpf { get; set; }
        public int idade { get; set; }

        public bool EhMaiorDeIdade()
        {
            return this.idade >= 18;
        }

        public  Cliente (string nome)
        {
            this.nome = nome;
        }
        public Cliente() { }
    }
}
