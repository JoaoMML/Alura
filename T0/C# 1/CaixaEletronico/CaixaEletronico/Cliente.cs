using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public class Cliente
    {

        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Endereco { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }

        public Cliente() { }

        public bool EhMaiorDeIdade()
        {
            return this.Idade >= 18;
        }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public override string ToString()
        {
            return "" + this.Nome;
        }
    }

}
