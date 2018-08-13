using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPattens
{
    class RealizadorDeInvestimentos
    {
        public void Realiza(Conta conta,Investimentos investimentos)
        {
            double resultado = investimentos.Calcula(conta);
            conta.Deposita(resultado * 0.75);
            Console.WriteLine("Novo Saldo" + conta.Saldo);
        }
    }
}
