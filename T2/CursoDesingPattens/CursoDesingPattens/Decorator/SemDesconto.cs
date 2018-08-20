using CursoDesingPattens.Aula_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPattens
{
    class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta (Orcamento orcamento)
        {
            return 0;
        }

    }
}
