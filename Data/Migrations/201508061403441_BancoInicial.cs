namespace TS.TesteEF.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BancoInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ingrediente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 250, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 250, unicode: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pedido",
                c => new
                    {
                        IdCliente = c.Int(nullable: false),
                        IdProduto = c.Int(nullable: false),
                        Quantidade = c.Decimal(nullable: false, precision: 18, scale: 0),
                    })
                .PrimaryKey(t => new { t.IdCliente, t.IdProduto })
                .ForeignKey("dbo.Cliente", t => t.IdCliente)
                .ForeignKey("dbo.Produto", t => t.IdProduto)
                .Index(t => t.IdCliente)
                .Index(t => t.IdProduto);
            
            CreateTable(
                "dbo.ProdutoIngrediente",
                c => new
                    {
                        Produto = c.Int(nullable: false),
                        Ingrediente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Produto, t.Ingrediente })
                .ForeignKey("dbo.Produto", t => t.Produto)
                .ForeignKey("dbo.Ingrediente", t => t.Ingrediente)
                .Index(t => t.Produto)
                .Index(t => t.Ingrediente);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pedido", "IdProduto", "dbo.Produto");
            DropForeignKey("dbo.Pedido", "IdCliente", "dbo.Cliente");
            DropForeignKey("dbo.ProdutoIngrediente", "Ingrediente", "dbo.Ingrediente");
            DropForeignKey("dbo.ProdutoIngrediente", "Produto", "dbo.Produto");
            DropIndex("dbo.ProdutoIngrediente", new[] { "Ingrediente" });
            DropIndex("dbo.ProdutoIngrediente", new[] { "Produto" });
            DropIndex("dbo.Pedido", new[] { "IdProduto" });
            DropIndex("dbo.Pedido", new[] { "IdCliente" });
            DropTable("dbo.ProdutoIngrediente");
            DropTable("dbo.Pedido");
            DropTable("dbo.Produto");
            DropTable("dbo.Ingrediente");
            DropTable("dbo.Cliente");
        }
    }
}
