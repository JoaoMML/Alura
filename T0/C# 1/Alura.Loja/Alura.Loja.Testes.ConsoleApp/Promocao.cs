﻿using System;
using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Promocao
    {
        public int Id { get; set; }
        public string Descricao { get; internal set; }
        public DateTime DataInicio { get; internal set; }
        public DateTime DataFinal { get; internal set; }
        public IList<PromocaoProduto> Produtos  { get; internal set; }
    }
}
