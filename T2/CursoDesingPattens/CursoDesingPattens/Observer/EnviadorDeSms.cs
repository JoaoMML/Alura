using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPattens.Observer
{
    public class EnviadorDeSms : AcaoAposGerarNota

    {
        public void Executa (NotaFiscal nf)
        {
            Console.WriteLine("Sms");
        }
    }
}
