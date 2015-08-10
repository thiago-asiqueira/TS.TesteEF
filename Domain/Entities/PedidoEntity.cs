
namespace TS.TesteEF.Domain.Entities
{
    public sealed class PedidoEntity
    {
        public ClienteEntity Cliente { get; set; }
        public int IdCliente { get; set; }
        public ProdutoEntity Produto { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
    }
}
