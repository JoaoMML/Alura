using Solid.Cap_2;
using Solid.Cap_3;
using Solid.Cap_4;
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
            IList<Boleto> boletos = new List<Boleto>();
            boletos.Add(new Boleto(200));
            boletos.Add(new Boleto(400));

            Fatura fatura = new Fatura("João", 900);

            ProcessadorDeBoletos pdb = new ProcessadorDeBoletos();

            pdb.Processa(boletos,fatura);

            Console.WriteLine(fatura.Pago);
            Console.ReadKey();
        }
    }
}
