using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class GerenciadorDeImpostos
    {
        public double Total { get; private set; }
        public void Adiciona(Tributavel tributavel)
        {
            this.Total += tributavel.CalculaTributo();
        }
    }
}
