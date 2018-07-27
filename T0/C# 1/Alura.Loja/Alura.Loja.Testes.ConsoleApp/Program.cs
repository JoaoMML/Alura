using Microsoft.EntityFrameworkCore.ChangeTracking;
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
        public static string Logradouro { get; private set; }
        public static string Complemento { get; private set; }
        public static string Bairro { get; private set; }
        public static string Cidade { get; private set; }

        static void Main(string[] args)
        {
            var fulano = new Cliente();
            fulano.Nome = " Fulaninho de tal ";
            fulano.EnderecoDeEntrega = new Endereco()
            {
                Numero = 18,
                Logradouro = "Rua Yolanda Grossi Cabral",
                Complemento = "Casa com sobrado ",
                Bairro = "Centro",
                Cidade = "Registro",
            };

            using (var contexto = new LojaContext())
            {
                contexto.Clientes.Add(fulano);
                contexto.SaveChanges();
            }
    }

    private static void MuitosParaMuitos()
    {
        var p1 = new Produto() { Nome = "Suco de Laranja", Categoria = "Bebidas", PrecoUnitario = 8.79, Unidade = "Litros" };
        var p2 = new Produto() { Nome = "Café", Categoria = "Bebidas", PrecoUnitario = 12.45, Unidade = "Gramas" };
        var p3 = new Produto() { Nome = "Macarrão", Categoria = "Alimentos", PrecoUnitario = 4.23, Unidade = "Gramas" };

        var promocaoDePascoa = new Promocao();
        promocaoDePascoa.Descricao = "Pascoa Feliz";
        promocaoDePascoa.DataInicio = DateTime.Now;
        promocaoDePascoa.DataFinal = DateTime.Now.AddMonths(3);

        promocaoDePascoa.IncluiProduto(p1);
        promocaoDePascoa.IncluiProduto(p2);
        promocaoDePascoa.IncluiProduto(p3);


        using (var contexto = new LojaContext())
        {
            //contexto.Promocoes.Add(promocaoDePascoa);
            var promocao = contexto.Promocoes.Find(1);
            contexto.Promocoes.Remove(promocao);
            contexto.SaveChanges();
        }
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
