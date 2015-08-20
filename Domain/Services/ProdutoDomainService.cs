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
    public sealed class ProdutoDomainService : IProdutoService
    {
        private readonly IRepositoryProduto _produtoRepository;

        public ProdutoDomainService(IRepositoryProduto produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void AtualizarProduto(ProdutoEntity produto)
        {
            _produtoRepository.Update(produto);
        }

        public void CadastrarProduto(ProdutoEntity produto)
        {
            _produtoRepository.Add(produto);
        }

        public ProdutoEntity ConsultarProdutoPorId(int idProduto)
        {
            return _produtoRepository.GetById(idProduto);
        }

        public IEnumerable<ProdutoEntity> ConsultarTodosProdutos()
        {
            return _produtoRepository.GetAll();
        }

        public void DeletarProduto(int idProduto)
        {
            _produtoRepository.DeleteById(idProduto);
        }
    }
}
