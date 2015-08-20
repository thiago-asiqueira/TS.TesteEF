using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.TesteEF.Domain.Entities;

namespace Application.Converters
{
    public static class PedidoConverter
    {
        public static PedidoDto ToDto(this PedidoEntity pedido)
        {
            return pedido == null ? null : new PedidoDto
            {
                Cliente = ClienteConverter.ToDto(pedido.Cliente),
                Produto = ProdutoConverter.ToDto(pedido.Produto),
                Quantidade = pedido.Quantidade
            };
        }
    }
}
