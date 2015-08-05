using TS.TesteEF.Domain.Contracts.Repositories.Core;
using TS.TesteEF.Domain.Entities;

namespace TS.TesteEF.Domain.Contracts.Repositories
{
    public interface IRepositoryCliente :
        IRepositoryAdd<ClienteEntity, int>
        , IRepositoryUpdate<ClienteEntity, int>
        , IRepositoryDelete<int>
        , IRepositoryGetAll<ClienteEntity, int>
        , IRepositoryGetById<int, ClienteEntity>
    {
    }
}
