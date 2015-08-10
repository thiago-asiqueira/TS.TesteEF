using Application.Dtos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class ProdutoDto : CoreDto
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}
