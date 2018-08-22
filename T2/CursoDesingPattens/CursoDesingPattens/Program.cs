using CursoDesingPattens.Observer;
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
            NotaFiscalBuilder criador = new NotaFiscalBuilder();
            criador
                .ParaEmpresa("Caelum ensino e Inovacao")
                .ComCnpj("23.456.789/0001-12")
                .ComItem(new ItemDaNota("item 1",100.0 ))
                .ComItem(new ItemDaNota("item 2", 200.0))
                .NaDataAtual()
                .ComObservacoes("uma obs qualquer");

            criador.AdicionaAcao(new EnviadorDeEmail());
            criador.AdicionaAcao(new EnviadorDeSms());
            criador.AdicionaAcao(new NotaFiscalDao());

            NotaFiscal nf = criador.Controi();
            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);


            Console.ReadKey();
        }
    }
}
