using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.TesteEF.Domain.Entities;

namespace TS.TesteEF.Domain.Factories
{
    public static class ProdutoFactory
    {
        public static ProdutoEntity Create(string nome, decimal valor, IngredienteEntity[] ingredientes)
        {
            return new ProdutoEntity(nome, valor, ingredientes);
        }
    }
}
