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
            // GravarUsandoEntity();
            //RecuperarProdutos();
            // RemoverProdutos();
            // RecuperarProdutos();
            //AtualizarProdutos();
        }

        private static void AtualizarProdutos()
        {
            // incluir um novo produto
            GravarUsandoEntity();
            RecuperarProdutos();

            // atualizar produto
            using (var repo = new LojaContext())
            {
                Produto primeiro = repo.Produtos.First();
                primeiro.Nome = "Texto Editado";
                repo.Produtos.Update(primeiro);
                repo.SaveChanges();
            }

            RecuperarProdutos();

        }

        private static void RemoverProdutos()
        {
            using (var repo = new LojaContext())
            {
                IList<Produto> produtos = repo.Produtos.ToList();
                foreach (var item in produtos)
                {
                    repo.Produtos.Remove(item);
                }
                repo.SaveChanges();
            }
        }

        private static void RecuperarProdutos()
        {
            using (var repo = new LojaContext())
            {
                IList<Produto> produtos = repo.Produtos.ToList();
                Console.WriteLine("Foram encontrados {0} produto(s).", produtos.Count);
                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
            }
        }

        private static void GravarUsandoEntity()
        {
            Produto p1 = new Produto();
            p1.Nome = "Harry Potter e a Ordem da Fênix";
            p1.Categoria = "Livros";
            p1.Preco = 19.89;

            Produto p2 = new Produto();
            p2.Nome = "Senhor dos Anéis 1";
            p2.Categoria = "Livros";
            p2.Preco = 19.89;

            Produto p3 = new Produto();
            p3.Nome = "O Monge e o Executivo";
            p3.Categoria = "Livros";
            p3.Preco = 19.89;

            using (var contexto = new LojaContext())
            {
                contexto.Produtos.AddRange(p1, p2, p3);
                contexto.SaveChanges();
            }
        }
    }
}
