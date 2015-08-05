
namespace TS.TesteEF.Domain.Entities
{
    public sealed class PedidoEntity
    {
        public ClienteEntity IdCliente { get; set; }
        public ProdutoEntity IdProduto { get; set; }
        public int Quantidade { get; set; }
    }
}
