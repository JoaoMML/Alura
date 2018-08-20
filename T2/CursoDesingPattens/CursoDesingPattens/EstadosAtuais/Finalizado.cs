using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPattens.EstadosAtuais
{
    class Finalizado : IEstados
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos finalizados ou recuzados não recebem descontos.");
        }

        public void Aprova (Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem descontos");
        }
        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem descontos");
        }
        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem descontos");
        }
    }
}
