using System;
using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Promocao
    {
        public string Descricao { get; internal set; }
        public DateTime DataInicio { get; internal set; }
        public object DataFinal { get; internal set; }
        public IList<Produto> Produtos  { get; internal set; }
    }
}
