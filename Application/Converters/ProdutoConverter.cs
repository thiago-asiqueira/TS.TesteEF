using Application.Dtos;
using TS.TesteEF.Domain.Entities;

namespace Application.Converters
{
    public static class ProdutoConverter
    {
        public static ProdutoDto ToDto(this ProdutoEntity produto)
        {
            return produto == null ? null : new ProdutoDto
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor
            };
        }
    }
}
