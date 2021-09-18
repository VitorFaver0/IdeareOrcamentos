namespace IdeareOrcamentos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _180921 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ID_Cliente = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Numero = c.String(),
                    })
                .PrimaryKey(t => t.ID_Cliente);
            
            CreateTable(
                "dbo.ListaMateriaisOrcamentoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ID_Orcamento = c.Int(nullable: false),
                        ID_Material = c.Int(nullable: false),
                        Quantidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Materials", t => t.ID_Material, cascadeDelete: true)
                .ForeignKey("dbo.Orcamentoes", t => t.ID_Orcamento, cascadeDelete: true)
                .Index(t => t.ID_Orcamento)
                .Index(t => t.ID_Material);
            
            CreateTable(
                "dbo.Orcamentoes",
                c => new
                    {
                        ID_Orcamento = c.Int(nullable: false, identity: true),
                        NomeProjeto = c.Int(nullable: false),
                        ValorProjeto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ID_Cliente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Orcamento)
                .ForeignKey("dbo.Clientes", t => t.ID_Cliente, cascadeDelete: true)
                .Index(t => t.ID_Cliente);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ListaMateriaisOrcamentoes", "ID_Orcamento", "dbo.Orcamentoes");
            DropForeignKey("dbo.Orcamentoes", "ID_Cliente", "dbo.Clientes");
            DropForeignKey("dbo.ListaMateriaisOrcamentoes", "ID_Material", "dbo.Materials");
            DropIndex("dbo.Orcamentoes", new[] { "ID_Cliente" });
            DropIndex("dbo.ListaMateriaisOrcamentoes", new[] { "ID_Material" });
            DropIndex("dbo.ListaMateriaisOrcamentoes", new[] { "ID_Orcamento" });
            DropTable("dbo.Orcamentoes");
            DropTable("dbo.ListaMateriaisOrcamentoes");
            DropTable("dbo.Clientes");
        }
    }
}
