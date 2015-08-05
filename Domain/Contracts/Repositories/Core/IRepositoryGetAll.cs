
using System.Collections.Generic;
using TS.TesteEF.Domain.Entities.Core;

namespace TS.TesteEF.Domain.Contracts.Repositories.Core
{
    public interface IRepositoryGetAll<out TEntity,TCodigo>
        where TEntity: Entity<TCodigo>
    {
        IEnumerable<TEntity> GetAll();
    }
}
