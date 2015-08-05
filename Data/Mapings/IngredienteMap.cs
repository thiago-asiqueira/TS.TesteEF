
using System.Data.Entity.ModelConfiguration;
using TS.TesteEF.Domain.Entities;

namespace TS.TesteEF.Data.Mapings
{
    public sealed class IngredienteMap: EntityTypeConfiguration<IngredienteEntity>
    {
        public IngredienteMap()
        {
            ToTable("Ingrediente");

            HasKey<int>(x => x.Id);

            Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .HasMaxLength(250)
                .IsRequired();
        }
    }
}
