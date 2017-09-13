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
            //GravarUsandoAdoNet();
            //GravarUsandoEntity();
            //RecuperarProdutos();
            //ExcluirProdutos();
            //RecuperarProdutos();
            AtualizarProduto();
        }

        private static void AtualizarProduto()
        {

            GravarUsandoEntity();
            RecuperarProdutos();

            using(var context = new ProdutoDAOEntity())
            {
                Produto p = context.Produtos().First();
                p.Nome = "aaaa teste";
                context.Atualizar(p);

            }

            RecuperarProdutos();
        }

        private static void ExcluirProdutos()
        {
            using(var context = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = context.Produtos();
                foreach(var item in produtos){
                    context.Remover(item);
                }
            }
        }

        private static void RecuperarProdutos()
        {
            using(var contexto = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = contexto.Produtos();

                foreach(var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
            }
        }

        private static void GravarUsandoEntity()
        {
            Produto p = new Produto();

            p.Nome = "Harry potter e a ordem da fenix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using(var contexto = new ProdutoDAOEntity())
            {
                contexto.Adicionar(p);
            }
        }

        private static void GravarUsandoAdoNet()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var repo = new ProdutoDAO())
            {
                repo.Adicionar(p);
            }
        }
    }
}
