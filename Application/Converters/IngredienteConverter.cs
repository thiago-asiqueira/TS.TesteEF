using Application.Dtos;
using TS.TesteEF.Domain.Entities;

namespace Application.Converters
{
    public static class IngredienteConverter
    {
        public static IngredienteDto ToDto(this IngredienteEntity ingrediente)
        {
            return ingrediente == null ? null : new IngredienteDto
            {
                Id = ingrediente.Id,
                Nome = ingrediente.Nome
            };
        }
    }
}
