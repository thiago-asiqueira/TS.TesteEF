using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.TesteEF.Domain.Entities.Core;

namespace TS.TesteEF.Domain.Contracts.Repositories.Core
{
    public interface IRepositoryAdd<in TEntity, TId>
        where TEntity: Entity<TId>
    {
        void Add(TEntity entity);
    }
}
