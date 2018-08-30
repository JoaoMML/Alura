using Solid.Cap_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            EnviadorDeEmail enviadorEmail = new EnviadorDeEmail();
            NotaFiscalDao nfDao = new NotaFiscalDao();
            IList<IAcaoAposGerarNota> acoes = new List<IAcaoAposGerarNota>();
            acoes.Add(new EnviadorDeEmail());
            acoes.Add(new NotaFiscalDao());
            acoes.Add(new SAP());
            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(acoes);
            Fatura fatura = new Fatura(200, "Joao Marcos");
            gerador.Gera(fatura);
            Console.ReadKey();
        }
    }
}
