
using System.Data.Entity.ModelConfiguration;
using TS.TesteEF.Domain.Entities;

namespace TS.TesteEF.Data.Mapings
{
    public sealed class ClienteMap : EntityTypeConfiguration<ClienteEntity>
    {
        public ClienteMap()
        {
            ToTable("Cliente");

            HasKey<int>(x => x.Id);

            Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.Nascimento)
                .HasColumnName("DataNascimento")
                .HasColumnType("datetime")
                .IsRequired();
        }
    }
}
