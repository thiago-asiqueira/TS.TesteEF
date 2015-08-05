
using TS.TesteEF.Domain.Entities.Core;

namespace TS.TesteEF.Domain.Contracts.Repositories.Core
{
    public interface IRepositoryGetById<in TId,TEntity>
        where TEntity: Entity<TId>
    {
        TEntity GetById(TId id);
    }
}
