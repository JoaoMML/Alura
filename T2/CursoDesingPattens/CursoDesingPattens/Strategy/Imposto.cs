using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPattens
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }
        public abstract double  Calcula(Orcamento orcamento);
    }
}