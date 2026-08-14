using System.ComponentModel.DataAnnotations;

namespace SistemaGestaoLoja.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public int Estoque { get; set; }

        public int CategoriaId { get; set; }
    }
}