using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPattens.ChainOfResponsibility
{
    class RespostaEmPorcento
    {
        IResposta OutraResposta { get; set; }

        public RespostaEmPorcento(IResposta outraResposta)
        {
            this.OutraResposta = outraResposta;
        }


        public void Responde(Requisicao req,Conta conta)
        {
            if (req.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.Titular + "%" + conta.Saldo);
            }
            else
            {
                OutraResposta.Responde(req,conta);
            }
        }
    }
}
