
using System.Collections.Generic;
using TS.TesteEF.Domain.Entities.Core;

namespace TS.TesteEF.Domain.Entities
{
    public sealed class IngredienteEntity : Entity<int>
    {
        public IngredienteEntity()
        {

        }

        public IngredienteEntity(string nome, ICollection<ProdutoEntity> produtos)
        {
            Nome = nome;
            Produtos = produtos;
        }

        public string Nome { get; set; }
        public ICollection<ProdutoEntity> Produtos { get; set; }
    }
}
