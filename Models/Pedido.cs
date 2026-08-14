using System.ComponentModel.DataAnnotations;

namespace SistemaGestaoLoja.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public int ClienteId { get; set; }
    }
}