using DesingPatterns2.Cap1;
using DesingPatterns2.Cap2;
using DesingPatterns2.Cap3;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            Historico historico = new Historico();
            Contrato c = new Contrato(DateTime.Now, "Victor", TipoDoContrato.Novo);

            historico.Adiciona(c.SalvaEstado());

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());

            Console.WriteLine(historico.Pega(2).Contrato.Tipo);

            Console.ReadKey();
            
        }

    }
}
