using Application.Dtos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public sealed class PedidoDto
    {
        public ClienteDto Cliente { get; set; }
        public ProdutoDto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
