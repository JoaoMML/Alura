using CursoDesingPattens.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPattens
{
    public class CriadorDeNotaFiscal
    {
        public String RazaoSocial { get; private set; }
        public String Cnpj { get; private set; }
        public String Observacoes { get; private set; }
        public DateTime Data { get; private set; }

        private double valorTotal;
        private double impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        private IList<AcaoAposGerarNota> TodasAcoesASeremExecutadas = new List<AcaoAposGerarNota>();

        public CriadorDeNotaFiscal ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }
        public CriadorDeNotaFiscal ComObservacoes (String observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }

        public NotaFiscal Controi()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, todosItens, Observacoes);
            foreach(AcaoAposGerarNota acao in TodasAcoesASeremExecutadas)
            {
                acao.Executa(nf);
            }

            return nf;
        }

        public void AdicionaAcao(AcaoAposGerarNota novaAcao)
        {
            this.TodasAcoesASeremExecutadas.Add(novaAcao);
        }

        public CriadorDeNotaFiscal NaDataAtual()
        {
            this.Data = DateTime.Now;
            return this;
        }
        public CriadorDeNotaFiscal ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }
        public CriadorDeNotaFiscal ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;
            return this;
        }
    }
}
