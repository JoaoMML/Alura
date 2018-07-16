using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Conta
    {
        public int numero { get; set; }
        public double saldo { get; private set; }
        public Cliente titular { get; set; }
        public int agencia { get; set; }
        public Cliente cliente { get; set; }

        public void Deposita(double valorASerDepositado)
        {
            if (valorASerDepositado > 0)
            {
                this.saldo += valorASerDepositado;
            }
        }

        public bool Saca(double valorASerSacado)
        {
            if (valorASerSacado > this.saldo || valorASerSacado < 0)
            {
                return false;
            }
            else
            {
                if (this.cliente.EhMaiorDeIdade())
                {
                    this.saldo -= valorASerSacado;
                    return true;
                }
                else
                {
                    if (valorASerSacado <= 200.0)
                    {
                        this.saldo -= valorASerSacado;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
    }
}