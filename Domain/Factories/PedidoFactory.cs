using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.TesteEF.Domain.Entities;

namespace TS.TesteEF.Domain.Factories
{
    public static class PedidoFactory
    {
        public static PedidoEntity Create(ClienteEntity cliente, ProdutoEntity produto, int quantidade)
        {
            return new PedidoEntity(cliente,produto,quantidade);
        }
    }
}
