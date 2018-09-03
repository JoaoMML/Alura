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
        private static double resultado;

        static void Main(string[] args)
        {
<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
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
=======
            CalculadoraDeSalario cs = new CalculadoraDeSalario();
            Funcionario funcionario = new Funcionario(new Desenvolvedor(new DezOuVintePorcento()), 2000.0);

            resultado = cs.Calcula(funcionario);

            Console.WriteLine("O salário de um desenvlvedor que ganha 2000 bruto é de", resultado);
>>>>>>> 2d17cf0a612b72f5c35e96ce069e8edd1f9bda6a
>>>>>>> 138f93b7d97a4fcb09ccf3f8d78c2198e790fc8f
=======
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
>>>>>>> 74ec9b33dc05d7a488c26b701bd2feb0276efc83
        }

    }
}
