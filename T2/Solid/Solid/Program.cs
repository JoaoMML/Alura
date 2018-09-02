using Solid.Cap_2;
using Solid.Cap_3;
using Solid.Cap_4;
using Solid.Cap5;
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
            IList<ContaComum> contas = ContasDoBanco();

            foreach(ContaComum conta in contas)
            {
                conta.Deposita(120);
                conta.CalculaValorDoJurosMensal();
                conta.SomaInvestimento();

                Console.WriteLine("Novo saldo: "+ conta.Saldo);
            }
            Console.ReadLine();
        }

        private static IList<ContaComum> ContasDoBanco()
        {
            List<ContaComum> contas = new List<ContaComum>();
            contas.Add(umaContaComum(100));
            contas.Add(umaContaComum(150));
            contas.Add(umaContaComum(100));
            return contas;
        }

    }
}
