using System.Collections.Generic;
using TS.TesteEF.Domain.Contracts.Repositories.Core;
using TS.TesteEF.Domain.Entities;

namespace TS.TesteEF.Domain.Contracts.Repositories
{
    public interface IRepositoryProduto :
        IRepositoryAdd<ProdutoEntity, int>
        , IRepositoryDelete<int>
        , IRepositoryGetAll<ProdutoEntity, int>
        , IRepositoryGetById<int, ProdutoEntity>
        , IRepositoryUpdate<ProdutoEntity, int>
    {
    }
}
