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
    public sealed class IngredienteDomainService : IIngredienteService
    {
        private readonly IRepositoryIngrediente _ingredienteRepository;

        public IngredienteDomainService(IRepositoryIngrediente ingredienteRepository)
        {
            _ingredienteRepository = ingredienteRepository;
        }

        public void AtualizarIngrediente(IngredienteEntity Ingrediente)
        {
            _ingredienteRepository.Update(Ingrediente);
        }

        public void CadastrarIngrediente(IngredienteEntity Ingrediente)
        {
            _ingredienteRepository.Add(Ingrediente);
        }

        public IngredienteEntity ConsultarIngredientePorId(int idCliente)
        {
            return _ingredienteRepository.GetById(idCliente);
        }

        public IEnumerable<IngredienteEntity> ConsultarIngredientePorNome(string nomeIngrediente)
        {
            return _ingredienteRepository.GetByNome(nomeIngrediente);
        }

        public IEnumerable<IngredienteEntity> ConsultarIngredientePorProduto(ProdutoEntity produto)
        {
            return _ingredienteRepository.GetByProduto(produto);
        }

        public IEnumerable<IngredienteEntity> ConsultarTodosIngredientes()
        {
            return _ingredienteRepository.GetAll();
        }

        public void DeletarIngrediente(int idIngrediente)
        {
            _ingredienteRepository.DeleteById(idIngrediente);
        }
    }
}
