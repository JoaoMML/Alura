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
            CalculadoraDeSalario cs = new CalculadoraDeSalario();
            Funcionario funcionario = new Funcionario(new Desenvolvedor(new DezOuVintePorcento()), 2000.0);

            resultado = cs.Calcula(funcionario);

            Console.WriteLine("O salário de um desenvlvedor que ganha 2000 bruto é de", resultado);
        }
    }
}
