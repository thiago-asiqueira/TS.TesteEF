
namespace TS.TesteEF.Domain.Entities
{
    public sealed class PedidoEntity
    {
        public PedidoEntity()
        {

        }

        public PedidoEntity(ClienteEntity cliente, ProdutoEntity produto, int quantidade)
        {
            Cliente = cliente;
            Produto = produto;
            Quantidade = quantidade;
            IdCliente = cliente.Id;
            IdProduto = produto.Id;
        }

        public ClienteEntity Cliente { get; set; }
        public int IdCliente { get; set; }
        public ProdutoEntity Produto { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
    }
}
