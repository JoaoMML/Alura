﻿using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
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
            var promocaoDePascoa = new Promocao();
            promocaoDePascoa.Descricao = "Pascoa Feliz";
            promocaoDePascoa.DataInicio = DateTime.Now;
            promocaoDePascoa.DataFinal = DateTime.Now.AddMonths(3);
            //promocaoDePascoa.Produtos.Add(new Produto());
            //promocaoDePascoa.Produtos.Add(new Produto());
            //promocaoDePascoa.Produtos.Add(new Produto());

        }

        private static void ExibeEntries(IEnumerable<EntityEntry> entries)
        {
            foreach (var e in entries)
            {
                Console.WriteLine(e.Entity.ToString() + " - " + e.State);
            }
        }
    }
}
