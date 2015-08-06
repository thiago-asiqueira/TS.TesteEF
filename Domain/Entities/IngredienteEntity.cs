
using System.Collections.Generic;
using TS.TesteEF.Domain.Entities.Core;

namespace TS.TesteEF.Domain.Entities
{
    public sealed class IngredienteEntity : Entity<int>
    {
        public string Nome { get; set; }
        public ICollection<ProdutoEntity> Produtos { get; set; }
    }
}
