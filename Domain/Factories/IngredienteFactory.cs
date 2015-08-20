using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.TesteEF.Domain.Entities;

namespace TS.TesteEF.Domain.Factories
{
    public static class IngredienteFactory
    {
        public static IngredienteEntity Create(string nome, ProdutoEntity[] produtos)
        {
            return new IngredienteEntity(nome, produtos);
        }
    }
}
