using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Compra de 6 pães 
            var paoFrances = new Produto();
            paoFrances.Nome = " Pão Francês";
            paoFrances.PrecoUnitario = 0.40;
            //paofrances.unidade = 1;
            paoFrances.Categoria = "Padaria";

            var compra = new Compra();
            compra.Quantidade = 6;
            compra.Produto = paoFrances;
            compra.Preco = paoFrances.PrecoUnitario * compra.Quantidade;

        }
    }
}
