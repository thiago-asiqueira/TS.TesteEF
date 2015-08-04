
namespace TS.TesteEF.Domain.Entities
{
    public sealed class Pedido
    {
        public ClienteEntity IdCliente { get; set; }
        public ProdutoEntity IdProduto { get; set; }
    }
}
