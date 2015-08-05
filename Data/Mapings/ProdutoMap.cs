using System.Data.Entity.ModelConfiguration;
using TS.TesteEF.Domain.Entities;

namespace TS.TesteEF.Data.Mapings
{
    public sealed class ProdutoMap: EntityTypeConfiguration<ProdutoEntity>
    {
        public ProdutoMap()
        {
            ToTable("Produto");

            HasKey<int>(x => x.Id);

            Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .HasMaxLength(250)
                .IsRequired();

            Property(x => x.Valor)
                .HasColumnName("Valor")
                .HasColumnType("decimal")
                .IsRequired();

            HasMany(x => x.Ingredientes).WithMany(c => c.Proutos)
                .Map(t => t.ToTable("ProdutoIngrediente")
                .MapLeftKey("Produto")
                .MapRightKey("Ingrediente"));
        }
    }
}
