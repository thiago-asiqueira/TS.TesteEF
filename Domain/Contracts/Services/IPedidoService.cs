using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.TesteEF.Domain.Entities;

namespace TS.TesteEF.Domain.Contracts.Services
{
    public interface IPedidoService
    {
        void CadastrarPedido(PedidoEntity Pedido);
        void DeletarPedido(ClienteEntity Cliente, ProdutoEntity Produto);
        void AtualizarPedido(PedidoEntity Pedido);
        IEnumerable<PedidoEntity> ConsultarTodosPedidos();
        IEnumerable<PedidoEntity> ConsultarPedidoPorProduto(ProdutoEntity Produto);
        IEnumerable<PedidoEntity> ConsultarPedidoPorCliente(ClienteEntity Cliente);
        PedidoEntity ConsultarPedidoPorId(ClienteEntity Cliente, ProdutoEntity Produto);
    }
}
