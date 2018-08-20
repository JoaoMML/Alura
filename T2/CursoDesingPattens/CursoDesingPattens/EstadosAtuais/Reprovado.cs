using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPattens.EstadosAtuais
{
    class Reprovado : IEstados
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.02);
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception(" O orçamento já foi aprovado, não pode ser recusado agora.");
           
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception(" O orçamento já está em estado 'RECUSADO' "); ;
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
