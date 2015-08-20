using Application.Dtos;
using TS.TesteEF.Domain.Entities;

namespace Application.Converters
{
    public static class ClienteConverter
    {
        public static ClienteDto ToDto(this ClienteEntity cliente)
        {
            return cliente == null ? null : new ClienteDto
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Nascimento = cliente.Nascimento
            };
        }
    }
}
