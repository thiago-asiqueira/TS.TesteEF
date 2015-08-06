using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using TS.TesteEF.Data.Context;
using TS.TesteEF.Domain.Contracts;
using TS.TesteEF.Domain.Contracts.Repositories;
using TS.TesteEF.Domain.Entities;

namespace TS.TesteEF.Data.Repositories
{
    public sealed class PedidoRepository : IRepositoryPedido
    {
        private readonly TesteEFContext _context;

        public PedidoRepository(TesteEFContext context)
        {
            _context = context;
        }

        public void Add(PedidoEntity pedido)
        {
            _context.PedidoEntities.Add(pedido);
        }

        public void Delete(ClienteEntity cliente, ProdutoEntity produto)
        {
            var item = GetByClienteProduto(cliente,produto);
            _context.PedidoEntities.Remove(item);
        }

        public IEnumerable<PedidoEntity> GetByCliente(ClienteEntity cliente)
        {
            return _context.PedidoEntities.Where(x => x.IdCliente == cliente).ToList();
        }

        public PedidoEntity GetByClienteProduto(ClienteEntity cliente, ProdutoEntity produto)
        {
            return _context.PedidoEntities.SingleOrDefault(x => x.IdCliente == cliente && x.IdProduto == produto);
        }

        public IEnumerable<PedidoEntity> GetByProduto(ProdutoEntity produto)
        {
            return _context.PedidoEntities.Where(x => x.IdProduto == produto).ToList();
        }

        public IEnumerable<PedidoEntity> ObterPedidoEspecial(int valorTotal = 100)
        {
            var pedidos = GetAll();
            var pedidosEspeciais = new List<PedidoEntity>();

            foreach (var item in pedidos)
            {
                if (item.IdProduto.Valor * item.Quantidade > valorTotal)
                {
                    pedidosEspeciais.Add(item);
                }
            }

            return pedidosEspeciais;
        }

        public void Update(PedidoEntity pedido)
        {
            _context.Entry(pedido).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public IEnumerable<PedidoEntity> GetAll()
        {
            return _context.PedidoEntities.ToList();
        }
    }
}
