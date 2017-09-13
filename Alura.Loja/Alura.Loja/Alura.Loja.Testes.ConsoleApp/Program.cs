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

            //Compra de 6 pães franceses

            var PaoFrances = new Produto()
            {
                Nome = "´Pão Frances",
                PrecoUnitario = 0.40,
                Unidade = "Unidade",
                Categoria = "Padaria"
            };


            Compra compra = new Compra();


            compra.Quantidade = 6;
            compra.Produto = PaoFrances;
            compra.Preco = PaoFrances.PrecoUnitario * compra.Quantidade;


            using(var contexto = new LojaContext())
            {
                contexto.Compras.Add(compra);
                contexto.SaveChanges();
            }
        }
        
    }
}
