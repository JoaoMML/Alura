using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPattens
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public string Nome { get; internal set; }
        public string Numero { get; internal set; }
        public string Agencia { get; internal set; }
        public DateTime DataAbertura { get; internal set; }
        

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
    }
}
