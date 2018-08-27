using DesingPatterns2.Cap1;
using DesingPatterns2.Cap2;
using DesingPatterns2.Cap3;
using DesingPatterns2.Cap4;
using DesingPatterns2.Cap5;
using DesingPatterns2.Cap6;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            IMensagem mensagem = new MensagemPorSMS("victor");
            mensagem.Envia();
        }

    }
}
