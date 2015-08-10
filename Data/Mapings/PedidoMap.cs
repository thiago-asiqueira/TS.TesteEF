

using System.Data.Entity.ModelConfiguration;
using TS.TesteEF.Domain.Entities;

namespace TS.TesteEF.Data.Mapings
{
    public sealed class PedidoMap : EntityTypeConfiguration<PedidoEntity>
    {
        public PedidoMap()
        {
            ToTable("Pedido");

            HasKey(x => new { x.IdCliente, x.IdProduto });

            HasRequired<ClienteEntity>(x => x.Cliente).WithMany().HasForeignKey(x => x.IdCliente);
            HasRequired<ProdutoEntity>(x => x.Produto).WithMany().HasForeignKey(x => x.IdProduto);

            Property(x => x.Quantidade)
                .HasColumnName("Quantidade")
                .HasColumnType("decimal")
                .IsRequired();
        }
    }
}
