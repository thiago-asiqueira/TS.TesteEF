using System.Collections.Generic;
using TS.TesteEF.Domain.Contracts.Repositories.Core;
using TS.TesteEF.Domain.Entities;

namespace TS.TesteEF.Domain.Contracts.Repositories
{
    public interface IRepositoryIngrediente :
        IRepositoryAdd<IngredienteEntity, int>
        , IRepositoryDelete<int>
        , IRepositoryGetAll<IngredienteEntity, int>
        , IRepositoryGetById<int, IngredienteEntity>
        , IRepositoryUpdate<IngredienteEntity, int>
    {
    }
}
