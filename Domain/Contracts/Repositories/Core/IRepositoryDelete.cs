
using TS.TesteEF.Domain.Entities.Core;

namespace TS.TesteEF.Domain.Contracts.Repositories.Core
{
    public interface IRepositoryDelete<in TId>
    {
        void DeleteById(TId id);
    }
}
