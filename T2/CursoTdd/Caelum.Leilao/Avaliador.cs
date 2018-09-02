using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Caelum.Leilao
{
    public class Avaliador
    {
        private double maiorDeTodos = Double.MinValue;
        private double menorDeTodos = Double.MaxValue;

        public void Avalia(Leilao leilao)
        {
            foreach(var lance in leilao.Lances)
            {
                if(lance.Valor> maiorDeTodos)
                {
                    maiorDeTodos = lance.Valor;
                }
                else if(lance.Valor > menorDeTodos)
                {
                    menorDeTodos = lance.Valor;
                }
            }
        }
    }
}