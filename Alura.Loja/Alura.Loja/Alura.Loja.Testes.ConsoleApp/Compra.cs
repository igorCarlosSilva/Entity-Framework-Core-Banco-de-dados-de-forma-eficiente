using System.ComponentModel.DataAnnotations;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Compra
    {
        [Key]
        public int IdCompra { get; set; }
        public int Quantidade { get; internal set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; internal set; }
        public double Preco { get; internal set; }

        public override string ToString()
        {
            return $"Compra de {this.Quantidade} do Produto {this.Produto}";
        }
    }
}