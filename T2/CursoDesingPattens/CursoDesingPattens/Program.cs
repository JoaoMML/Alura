using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPattens
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("CANETA", 250));
            //orcamento.AdicionaItem(new Item("LAPIS", 250));
            //orcamento.AdicionaItem(new Item("XBOX", 250));
            //orcamento.AdicionaItem(new Item("PAPEL", 250));
            //orcamento.AdicionaItem(new Item("PC", 250));
            //orcamento.AdicionaItem(new Item("GELADEIRA", 250));
            //orcamento.AdicionaItem(new Item("CANECA", 250));

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);
            Console.ReadKey();

        }
    }
}
