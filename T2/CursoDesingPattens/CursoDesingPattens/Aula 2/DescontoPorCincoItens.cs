using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPattens.Aula_2
{
    public class DescontoPorCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Desconta(Orcamento orcamento)
        {
            // 1° regra mais de 5 itens
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }

            return Proximo.Desconta(orcamento);

        }
    }
}
