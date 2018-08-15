using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPattens.ChainOfResponsibility
{
    interface IResposta
    {
        void Responde(Requisicao req, Conta conta);
    }
}
