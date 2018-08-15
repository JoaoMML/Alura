using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPattens.ChainOfResponsibility
{
    class RespostaEmCsv
    {
        public IResposta OutraResposta { get; set; }
        public RespostaEmCsv(IResposta outraResposta)
        {
            this.OutraResposta = outraResposta;
        }

        public RespostaEmCsv()
        {
            this.OutraResposta = null; // nao recebi a proxima!
        }

        public void Responde (Requisicao req , Conta conta)
        {
            if(req.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);
            }
            else if (OutraResposta != null)
            {
                OutraResposta.Responde(req, conta);
            }
            else
            {
                throw new Exception("Formato de resposta não encontrado");

            }
        }
    }
}
