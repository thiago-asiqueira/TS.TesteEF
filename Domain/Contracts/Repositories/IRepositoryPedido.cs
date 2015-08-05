using System.Collections.Generic;
using TS.TesteEF.Domain.Contracts.Repositories.Core;
using TS.TesteEF.Domain.Entities;

namespace TS.TesteEF.Domain.Contracts.Repositories
{
    public interface IRepositoryPedido
    {
        void Add(PedidoEntity pedido);
        void Delete(ClienteEntity cliente, ProdutoEntity produto);
        void Update(PedidoEntity pedido);
        IEnumerable<PedidoEntity> GetByCliente(ClienteEntity cliente);
        IEnumerable<PedidoEntity> GetByProduto(ProdutoEntity produto);
        IEnumerable<PedidoEntity> ObterPedidoEspecial();
    }
}
