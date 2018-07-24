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
            using (var repo = new ProdutoDAOEntity())
            {
                Produto primeiro = repo.Produtos().First();
                primeiro.Nome = "Texto Editado";
                repo.Atualizar(primeiro);
                
            }

            RecuperarProdutos();

        }

        private static void RemoverProdutos()
        {
            using (var repo = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = repo.Produtos();
                foreach (var item in produtos)
                {
                    repo.Remover(item);
                }
            
            }
        }

        private static void RecuperarProdutos()
        {
            using (var repo = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = repo.Produtos();
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


            using (var repo = new ProdutoDAOEntity())
            {
                repo.Adicionar(p1);
   
            }
        }
    }
}
