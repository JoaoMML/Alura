using Reflection.Infra;
using Reflection.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection.Controller
{
    public class CambioController : ControllerBase
    {
        private ICambioService _cambioService;

        public CambioController()
        {
            _cambioService = new CambioTestService();
        }

        public string MXN()
        {
            var valorFinal = _cambioService.Calcular("MXN", "BRL", 1);

            var textoPagina = View();


            var textoResultado = textoPagina.Replace("VALOR_EM_REAIS", valorFinal.ToString());

            return textoResultado;
        }
        public string USD()
        {
            var valorFinal = _cambioService.Calcular("MXN", "BRL", 1);
            var textoPagina = View();

            var TextoResultado = textoPagina.Replace("VALOR_EM_REAIS", valorFinal.ToString());

            return TextoResultado;
        }

        public string Calculo(string moedaOrigem, string moedaDestino, decimal valor)
        {
            var valorFinal = _cambioService.Calcular(moedaOrigem, moedaDestino, valor);
            var textoPagina = View();


            var textoResultado =
            textoPagina
            .Replace("VALOR_MOEDA_ORIGEM", valor.ToString())
            .Replace("VALOR_MOEDA_DESTINO", valorFinal.ToString())
            .Replace("MOEDA_ORIGEM", moedaOrigem)
            .Replace("MOEDA_DESTINO", moedaDestino);

            return textoResultado;
        }

        public string Calculo(string moedaDestino, decimal valor) =>
         Calculo("BRL", moedaDestino, valor);
        
    }
}

