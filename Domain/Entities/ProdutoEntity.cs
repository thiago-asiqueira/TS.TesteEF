
using TS.TesteEF.Domain.Entities.Core;

namespace TS.TesteEF.Domain.Entities
{
    public sealed class ProdutoEntity : Entity<int>
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}
