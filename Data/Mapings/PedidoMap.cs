

using System.Data.Entity.ModelConfiguration;
using TS.TesteEF.Domain.Entities;

namespace TS.TesteEF.Data.Mapings
{
    public sealed class PedidoMap : EntityTypeConfiguration<PedidoEntity>
    {
        public PedidoMap()
        {
            ToTable("Pedido");

            HasKey(s => new { s.IdCliente, s.IdProduto });

            Property(x => x.Quantidade)
                .HasColumnName("Quantidade")
                .HasColumnType("decimal")
                .IsRequired();
        }
    }
}
