using DesingPatterns2.Cap1;
using DesingPatterns2.Cap2;
using DesingPatterns2.Cap3;
using DesingPatterns2.Cap4;
using DesingPatterns2.Cap5;
using DesingPatterns2.Cap6;
using DesingPatterns2.Cap7;
using DesingPatterns2.Cap8;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesingPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.Nome = "João";
            cliente.Endereco = "Rua cinco";
            cliente.DataDeNascimento = DateTime.Now;

            String xml = new GeradorDeXml().GeraXml(cliente);

            Console.WriteLine(xml);
        }

    }
}
