using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns2.Cap3
{
    class Contrato
    {
        public DateTime Data { get; private set; }
        public string Cliente { get; private set; }
        public TipoDoContrato Tipo { get; private set; }

        public Contrato(DateTime data, string cliente, TipoDoContrato tipo)
        {
            this.Data = data;
            this.Cliente = cliente;
            this.Tipo = tipo;
        }

        public void Avanca()
        {
            if (this.Tipo == TipoDoContrato.Novo) this.Tipo = TipoDoContrato.EmAndamento;
            else if (this.Tipo == TipoDoContrato.EmAndamento) this.Tipo = TipoDoContrato.Acertado;
            else if (this.Tipo == TipoDoContrato.Acertado) this.Tipo = TipoDoContrato.Concluido;

        }
        public Estado SalvaEstado()
        {
            return new Estado(new Contrato(this.Data, this.Cliente, this.Tipo));
        }
    }
}
