using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    abstract class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public Cliente cliente { get; set; }
        public int TipoConta { get; set; }

        public abstract void Deposita(double valorASerDepositado);

        public abstract bool Saca(double valorASerSacado);

        public abstract void Transfere(Conta destino, double valor);
    }
}