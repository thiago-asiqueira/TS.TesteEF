using System.Data.Entity;
using TS.TesteEF.Domain.Entities;
using Conventions = System.Data.Entity.ModelConfiguration.Conventions;

namespace TS.TesteEF.Data.Context
{
    public sealed class TesteEFContext : DbContext
    {
        public TesteEFContext(): base("TesteEF")
        {
        }

        public DbSet<ClienteEntity> ClienteEntities { get; set; }
        public DbSet<IngredienteEntity> IngredienteEntities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Conventions.Remove<Conventions.PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<Conventions.OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<Conventions.ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new Mapings.ClienteMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
