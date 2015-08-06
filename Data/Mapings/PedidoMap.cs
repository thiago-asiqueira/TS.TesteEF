

using System.Data.Entity.ModelConfiguration;
using TS.TesteEF.Domain.Entities;

namespace TS.TesteEF.Data.Mapings
{
    public sealed class PedidoMap : EntityTypeConfiguration<PedidoEntity>
    {
        public PedidoMap()
        {
            ToTable("Pedido");

            HasKey(s => new { IdCliente = s.IdCliente.Id, IdProduto = s.IdProduto.Id });

            Property(x => x.Quantidade)
                .HasColumnName("Quantidade")
                .HasColumnType("decimal")
                .IsRequired();
        }
    }
}
