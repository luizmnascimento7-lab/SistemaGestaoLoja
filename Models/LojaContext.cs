using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using SistemaGestaoLoja.Models;

namespace SistemaGestaoLoja.Models
{
    public class LojaContext : DbContext
    {
        public LojaContext(DbContextOptions<LojaContext> options)
            : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<SistemaGestaoLoja.Models.Produto> Produto { get; set; } = default!;
        public DbSet<SistemaGestaoLoja.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<SistemaGestaoLoja.Models.Pedido> Pedido { get; set; } = default!;
        public DbSet<SistemaGestaoLoja.Models.ItemPedido> ItemPedido { get; set; } = default!;
    }
}