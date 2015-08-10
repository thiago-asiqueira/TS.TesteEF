using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.TesteEF.Domain.Contracts.Repositories;
using TS.TesteEF.Domain.Contracts.Services;
using TS.TesteEF.Domain.Entities;

namespace TS.TesteEF.Domain.Services
{
    public sealed class PedidoDomainService : IPedidoService
    {
        private readonly IRepositoryPedido _pedidoRepository;

        public PedidoDomainService(IRepositoryPedido pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public void AtualizarPedido(PedidoEntity Pedido)
        {
            _pedidoRepository.Update(Pedido);
        }

        public void CadastrarPedido(PedidoEntity Pedido)
        {
            _pedidoRepository.Add(Pedido);
        }

        public IEnumerable<PedidoEntity> ConsultarPedidoPorCliente(ClienteEntity Cliente)
        {
            return _pedidoRepository.GetByCliente(Cliente);
        }

        public PedidoEntity ConsultarPedidoPorId(ClienteEntity Cliente, ProdutoEntity Produto)
        {
            return _pedidoRepository.GetByClienteProduto(Cliente,Produto);
        }

        public IEnumerable<PedidoEntity> ConsultarPedidoPorProduto(ProdutoEntity Produto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PedidoEntity> ConsultarPedidoPorProduto(int idProduto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PedidoEntity> ConsultarTodosPedidos()
        {
            throw new NotImplementedException();
        }

        public void DeletarPedido(int idPedido)
        {
            throw new NotImplementedException();
        }
    }
}
