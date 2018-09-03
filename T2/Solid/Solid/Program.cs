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
        private static double resultado;

        static void Main(string[] args)
        {
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
        }
    }
}
