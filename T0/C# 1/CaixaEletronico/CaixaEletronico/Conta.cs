using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Conta
    {
        public int numero;
        public string titular;
        public double saldo;
        public string cpf;
        public int agencia;

        public void Deposita(double valorASerDepositado)
        {
            if (valorASerDepositado > 0)
            {
                this.saldo += valorASerDepositado;
            }
        }

        public void Saca(double valorASerSacado)
        {
            if (valorASerSacado <= this.saldo && valorASerSacado > 0)
            {
                this.saldo -= valorASerSacado;
            }
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
    }
}