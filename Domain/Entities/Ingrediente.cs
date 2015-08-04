
using TS.TesteEF.Domain.Entities.Core;

namespace TS.TesteEF.Domain.Entities
{
    public sealed class Ingrediente : Entity<int>
    {
        public string Nome { get; set; }
    }
}
