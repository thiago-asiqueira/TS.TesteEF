using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.TesteEF.Domain.Entities.Core;

namespace TS.TesteEF.Domain.Contracts.Repositories.Core
{
    public interface IRepositoryUpdate<in TEntity, TId>
        where TEntity: Entity<TId>
    {
        void Update(TEntity entity);
    }
}
