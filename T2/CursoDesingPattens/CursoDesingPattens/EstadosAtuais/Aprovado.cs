using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPattens.EstadosAtuais
{
   public class Aprovado : IEstados
    {
        private bool descontoAplicado = false;
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                descontoAplicado = true;
            }
            else
            {
                throw new Exception("Desconto já aplicado!");
            }
        }
        public void Aprova(Orcamento orcamento)
        {
            throw new Exception(" O orçamento já está em estado 'APROVADO' ");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamentos)
        {
            throw new Exception(" O orçamento já foi aprovado, não pode ser recusado agora.");
        }
    }
}
