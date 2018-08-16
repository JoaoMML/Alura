using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPattens.TemplateMethod
{
    class RelatorioSimples : Relatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco do João");
        }
        protected override void Rodape()
        {
            Console.WriteLine("(11)99978-1212");
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach(Conta c in contas)
            {
                Console.WriteLine(c.Nome+ " - " + c.Saldo);
            }
        }
    }
}

