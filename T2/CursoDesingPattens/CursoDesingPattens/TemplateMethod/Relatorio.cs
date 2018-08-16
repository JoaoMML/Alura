using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPattens.TemplateMethod
{
    public abstract class Relatorio
    {
        protected abstract void Cabecalho();
        protected abstract void Rodape();
        protected abstract void Corpo(IList<Conta>contas);

        public void imprime (IList<Conta> contas)
        {
            Cabecalho();
            Corpo(contas);
            Rodape();
        }

    }
}
