using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public Cliente cliente { get; set; }
        public int TipoConta { get; set; }

        public virtual void Deposita(double valorASerDepositado)
        {
            if (valorASerDepositado > 0)
            {
                if (TipoConta == 1)
                {
                    this.Saldo += valorASerDepositado;
                }
                else if (TipoConta == 2)
                {
                    this.Saldo += valorASerDepositado + 0.10;
                }
            }
        }

        public bool Saca(double valorASerSacado)
        {
            if (valorASerSacado > this.Saldo || valorASerSacado < 0)
            {
                return false;
            }
            else
            {
                if (this.Titular.EhMaiorDeIdade())
                {
                    this.Saldo -= valorASerSacado;
                    return true;
                }
                else
                {
                    if (valorASerSacado <= 200.0)
                    {
                        this.Saldo -= valorASerSacado;
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