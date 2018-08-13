using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPattens
{
    public class Conservador : Investimentos
    {
        public double Calcula(Conta conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
