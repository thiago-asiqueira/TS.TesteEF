using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.TesteEF.Domain.Entities;

namespace TS.TesteEF.Domain.Contracts.Services
{
    public interface IIngredienteService
    {
        void CadastrarIngrediente(IngredienteEntity Ingrediente);
        void DeletarIngrediente(int idIngrediente);
        void AtualizarIngrediente(IngredienteEntity Ingrediente);
        IEnumerable<IngredienteEntity> ConsultarTodosIngredientes();
        IEnumerable<IngredienteEntity> ConsultarIngredientePorProduto(ProdutoEntity produto);
        IngredienteEntity ConsultarIngredientePorId(int idCliente);
        IEnumerable<IngredienteEntity> ConsultarIngredientePorNome(string nomeIngrediente);
    }
}
