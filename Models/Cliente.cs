using System.ComponentModel.DataAnnotations;

namespace SistemaGestaoLoja.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }
    }
}