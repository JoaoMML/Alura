using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns2.Cap9
{
    class EmpresaFacadeSingleton
    {
        private static EmpresaFacade instancia = new EmpresaFacade();

        public EmpresaFacade Instancia
        {
            get
            {
                return instancia;
            }
        }
    }
}
