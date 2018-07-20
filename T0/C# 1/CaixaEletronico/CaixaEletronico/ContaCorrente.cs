using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class ContaCorrente : Conta
    {
        public override void Deposita(double valorASerDepositado)
        {
            if (valorASerDepositado > 0)
                this.Saldo += valorASerDepositado;
        }
        public override bool Saca(double valorASerSacado)
        {
            if (valorASerSacado > this.Saldo || valorASerSacado < 0)
            {
                return false;
            }
            else
            {
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
        }
        public override void Transfere(Conta destino, double valor)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
    }
}


