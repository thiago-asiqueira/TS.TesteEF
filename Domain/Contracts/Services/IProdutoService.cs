using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.TesteEF.Domain.Entities;

namespace TS.TesteEF.Domain.Contracts.Services
{
    public interface IProdutoService
    {
        void CadastrarProduto(ProdutoEntity produto);
        void DeletarProduto(int idProduto);
        void AtualizarProduto(ProdutoEntity produto);
        IEnumerable<ProdutoEntity> ConsultarTodosProdutos();
        ProdutoEntity ConsultarProdutoPorId(int idProduto);
    }
}
